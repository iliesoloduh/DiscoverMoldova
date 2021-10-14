import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-update-resort-page',
  templateUrl: './add-update-resort-page.component.html',
  styleUrls: ['./add-update-resort-page.component.css']
})
export class AddUpdateResortPageComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  resortForm: FormGroup = new FormGroup({
    'name' : new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]),
    'address' : new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]),
    'email' : new FormControl(null, [Validators.required, Validators.email, Validators.maxLength(100)]),
    'price' : new FormControl(null, [Validators.required, Validators.pattern('^[1-9][0-9]+$')]),
    'capacity' : new FormControl(null, [Validators.required, Validators.pattern('^[1-9][0-9]+$')]),
    'phone' : new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(30), Validators.pattern('^[0-9]{3,10}$')]),
    'description' : new FormControl(null, Validators.required),
    'district' : new FormControl(null, Validators.required),
    'location' : new FormControl(null, Validators.required)
  });

  districts = ['Chișinău', 'Bălți', 'Briceni', 'Cricova', 'Criuleni', 'Drochia', 'Fălești', 'Giurgiulești', 'Hîncești', 'Ialoveni', 'Nisporeni', 'Rezina', 'Strășeni', 'Telenești'];
  locations = ['Bucovăț', 'Ciorești', 'Cruzești', 'Dănceni', 'Etulia', 'Fetești', 'Frăsinești', 'Frumoasa', 'Gordinești', 'Gura Bîcului', 'Horești', 'Hulboaca', 'Iurceni', 'Marinici', 'Rassvet'];
  facilities = ['Wifi', 'BBQ', 'Swimming pool', 'Sauna', 'Soccer field', 'Volleyball field', 'Basketball field', 'Restaurant', 'Fridge', 'TV', 'Billiard room', 'Parking'];
  

  onSubmit() {
    if (this.resortForm.valid) {
      // this.authService.registerUser(this.registerForm.value)
      // .subscribe(
      //   () => { this.router.navigate(['/login'])},
      //   (error) => {this.validationError = error.error;}
      // );
    }
  }

  getNameErrorMessage(){

    if (this.resortForm.controls['name'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.resortForm.controls['name'].hasError('minlength')) {
      return 'Minimum 3 characters long';
    }

    if (this.resortForm.controls['name'].hasError('maxlength')) {
      return 'Maximum 100 characters long';
    }

    return '';
  }

  getAddressErrorMessage(){

    if (this.resortForm.controls['address'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.resortForm.controls['address'].hasError('minlength')) {
      return 'Minimum 3 characters long';
    }

    if (this.resortForm.controls['address'].hasError('maxlength')) {
      return 'Maximum 100 characters long';
    }

    return '';
  }

  getEmailErrorMessage(){

    if (this.resortForm.controls['email'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.resortForm.controls['email'].hasError('email')) {
      return 'Enter a valid email';
    }

    if (this.resortForm.controls['email'].hasError('maxlength')) {
      return 'Maximum 100 characters long';
    }

    return '';
  }

  getPriceErrorMessage(){

    if (this.resortForm.controls['price'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.resortForm.controls['price'].hasError('pattern')) {
      return 'Enter a valid price';
    }

    return '';
  }

  getCapacityErrorMessage(){

    if (this.resortForm.controls['capacity'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.resortForm.controls['capacity'].hasError('pattern')) {
      return 'Enter a valid capacity';
    }

    return '';
  }

  getPhoneErrorMessage(){

    if (this.resortForm.controls['phone'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.resortForm.controls['phone'].hasError('pattern')) {
      return 'Enter a valid phone number';
    }

    if (this.resortForm.controls['phone'].hasError('minlength')) {
      return 'Minimum 3 characters long';
    }

    if (this.resortForm.controls['phone'].hasError('maxlength')) {
      return 'Maximum 30 characters long';
    }

    return '';
  }

  getDescriptionErrorMessage(){

    if (this.resortForm.controls['description'].hasError('required')) {
      return 'You must enter a value';
    }

    return '';
  }

  getDistrictErrorMessage(){

    if (this.resortForm.controls['district'].hasError('required')) {
      return 'You must enter a value';
    }

    return '';
  }

  getLocationErrorMessage(){

    if (this.resortForm.controls['location'].hasError('required')) {
      return 'You must enter a value';
    }

    return '';
  }
}
