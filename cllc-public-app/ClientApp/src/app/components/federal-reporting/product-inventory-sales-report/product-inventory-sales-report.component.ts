import { Component, OnInit, Input } from "@angular/core";
import { FormGroup, ValidationErrors } from "@angular/forms";
import { faChevronLeft, faQuestionCircle } from "@fortawesome/free-solid-svg-icons";
import {
  fieldValidationErrors,
  formValidationErrors,
  ClosingInventoryValidator,
  SalesValidator,
  ClosingValueValidator,
  ClosingWeightValidator,
  ClosingSeedsTotalValidator
} from "../federal-reporting-validation";

@Component({
  selector: "app-product-inventory-sales-report",
  templateUrl: "./product-inventory-sales-report.component.html",
  styleUrls: ["./product-inventory-sales-report.component.scss"]
})
export class ProductInventorySalesReportComponent implements OnInit {
  faQuestionCircle = faQuestionCircle;
  faChevronLeft = faChevronLeft;
  @Input()
  productForm: FormGroup;
  @Input()
  visible: boolean = true;

  constructor() { }

  ngOnInit() {
    if (this.productForm.get("product").value === "Seeds") {
      this.productForm.setValidators([
        ClosingInventoryValidator, ClosingValueValidator, ClosingSeedsTotalValidator, SalesValidator,
      ]);
    } else if (this.productForm.get("product").value === "Vegetative Cannabis") {
      this.productForm.setValidators([ClosingInventoryValidator, ClosingValueValidator, SalesValidator,]);
    } else {
      this.productForm.setValidators([
        ClosingInventoryValidator, ClosingValueValidator, ClosingWeightValidator, SalesValidator
      ]);
    }
  }

  getFieldValidationErrors() {
    const errorStrings = [];
    Object.keys(this.productForm.controls).forEach(key => {
      const controlErrors = this.productForm.get(key).errors;
      if (controlErrors != null) {
        Object.keys(controlErrors).forEach(keyError => {
          const error = fieldValidationErrors[key].find(e => e.type === keyError);
          if (error && errorStrings.findIndex(e => e === error.message) === -1) {
            errorStrings.push(error.message);
          }
        });
      }
    });
    return errorStrings;
  }

  getFormValidationErrors() {
    const alertStrings = [];
    if (this.productForm.errors !== null) {
      Object.keys(this.productForm.errors).forEach(key => {
        alertStrings.push(formValidationErrors[key]);
      });
    }
    return alertStrings;
  }

  isFieldInvalid(fieldName: string) {
    return !this.productForm.get(fieldName).valid && (this.productForm.dirty || this.productForm.touched);
  }
}
