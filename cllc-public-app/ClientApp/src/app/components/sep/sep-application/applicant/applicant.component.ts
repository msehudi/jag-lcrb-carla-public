import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AppState } from '@app/app-state/models/app-state';
import { PolicyDocumentComponent } from '@components/policy-document/policy-document.component';
import { Account } from '@models/account.model';
import { Contact } from '@models/contact.model';
import { SepApplication } from '@models/sep-application.model';
import { Store } from '@ngrx/store';
import { ContactDataService } from '@services/contact-data.service';
import { IndexedDBService } from '@services/indexed-db.service';
import { SpecialEventsDataService } from '@services/special-events-data.service';
import { Observable } from 'rxjs';
import { from } from 'rxjs/internal/observable/from';
import { of } from 'rxjs/internal/observable/of';

@Component({
  selector: 'app-applicant',
  templateUrl: './applicant.component.html',
  styleUrls: ['./applicant.component.scss']
})
export class ApplicantComponent implements OnInit {
  policySlug = "sep-terms-and-conditions";
  @ViewChild("policyDocs", { static: true })
  policyDocs: PolicyDocumentComponent;
  @Input() account: Account;
  _app: SepApplication = {} as SepApplication;
  contact: Contact;
  @Input()
  set application(value) {
    this._app = value;
    if (this.form) {
      this.form.patchValue(value);
    }
  };
  get application() {
    return this._app;
  }
  @Output()
  saveComplete = new EventEmitter<SepApplication>();
  form: FormGroup;


  constructor(private fb: FormBuilder,
    store: Store<AppState>,
    contactDataService: ContactDataService,
    private db: IndexedDBService) {
    store.select(state => state.currentUserState.currentUser)
      .subscribe(user => {
        contactDataService.getContact(user.contactid)
          .subscribe(contact => {
            this.contact = contact;
          });
      });
  }

  ngOnInit(): void {
    this.form = this.fb.group({
      eventName: ['', [Validators.required]],
      applicantInfo: [''],
      isAgreeTsAndCs: ['', [this.customRequiredCheckboxValidator()]],
      dateAgreedToTsAndCs: ['']
    });

    if (this.application) {
      this.form.patchValue(this.application);
    }

    this.form.get('isAgreeTsAndCs').valueChanges
      .subscribe((agree: boolean) => {
        if (agree) {
          this.form.get('dateAgreedToTsAndCs').setValue(new Date());
        }
      });

    this.policyDocs.setSlug(this.policySlug);
  }

  customRequiredCheckboxValidator(): ValidatorFn {
    return (control: AbstractControl): { [key: string]: any } | null => {
      if (control.value === true) {
        return null;
      } else {
        return { 'shouldBeTrue': 'But value is false' };
      }
    };
  }

  isValid() {
    this.form.markAsTouched();
    return this.form.valid;
  }

  next() {
    const data = {
      ...this.application,
      lastUpdated: new Date(),
      eventStatus: 'Draft',
      lastStepCompleted: 'applicant',
      ...this.form.value
    } as SepApplication;
    if (this.isValid()) {
      this.saveComplete.emit(data);
    }
  }


}
