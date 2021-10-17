import { Component, Input, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { _countGroupLabelsBeforeOption } from '@angular/material/core';
import { Router } from '@angular/router';
import { FacilityViewModel } from 'src/app/models/facility.model';
import { DistrictViewModel } from 'src/app/models/location/district.model';
import { LocationViewModel } from 'src/app/models/location/location.model';
import { ResortViewModel } from 'src/app/models/resort/resort.model';
import { FacilityService } from 'src/app/services/facility.service';
import { LocationService } from 'src/app/services/location.service';
import { ResortService } from 'src/app/services/resort.service';

@Component({
  selector: 'app-add-update-resort-page',
  templateUrl: './add-update-resort-page.component.html',
  styleUrls: ['./add-update-resort-page.component.css']
})
export class AddUpdateResortPageComponent implements OnInit {

  resortForm!: FormGroup;
  facilitiesList: FacilityViewModel[] = [];
  selectedFacilitiesIds: number[] = [];
  imageurls: any = [];
  base64String!: string;
  name!: string;
  imagePath!: string; 
  districts: DistrictViewModel[] = [];
  locations: LocationViewModel[] = [];

  @Input()
  resort : ResortViewModel | undefined;

  constructor(private formBuilder: FormBuilder, 
              private facilityService: FacilityService,
              private locationService: LocationService,
              private resortService: ResortService,
              private router: Router) { }

  ngOnInit(): void {
    console.log(localStorage.getItem('user'));
    this.resortForm = this.formBuilder.group({
      'name' : new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]),
      'address' : new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]),
      'email' : new FormControl(null, [Validators.required, Validators.email, Validators.maxLength(100)]),
      'price' : new FormControl(null, [Validators.required, Validators.pattern('^[1-9][0-9]+$')]),
      'capacity' : new FormControl(null, [Validators.required, Validators.pattern('^[1-9][0-9]+$')]),
      'phone' : new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(30), Validators.pattern('^[0-9]{3,10}$')]),
      'description' : new FormControl(null, Validators.required),
      'districtId' : new FormControl(this.resort ? this.resort.districtId : null, Validators.required),
      'locationId' : new FormControl(null, Validators.required)
    });

    this.facilityService.getAllFacilities().subscribe(
      (response) => {
        this.facilitiesList = response;
      });

    if(this.resort) {
      this.selectedFacilitiesIds = this.resort.facilitiesIds;
      this.locationService.getLocationsByDistrictId(this.resort.districtId).subscribe(
        (response) => {
          this.locations = response;
        });
    }

    this.locationService.getAllDistricts().subscribe(
      (response) => {
        this.districts = response;
      });
  }

  getLocationsByDistrictId(event: any){
    this.locationService.getLocationsByDistrictId(event.value).subscribe(
      (response) => {
        this.locations = response;
      });
  }

  onSelectFacility(id: number){
    if(this.selectedFacilitiesIds.includes(id)) {
      this.selectedFacilitiesIds.splice(this.selectedFacilitiesIds.indexOf(id), 1);
    }
    else {
      this.selectedFacilitiesIds.push(id);
    }
  }

  removeImage(i: number) {
    this.imageurls.splice(i, 1);
  }

  onSelectFile(event: any) {
    if (event.target.files && event.target.files[0]) {
      var filesAmount = event.target.files.length;
      for (let i = 0; i < filesAmount; i++) {
        var reader = new FileReader();
        reader.onload = (event: any) => {
          this.imageurls.push( event.target.result );
        }
        reader.readAsDataURL(event.target.files[i]);
      }

      // for (let i = 0; i < event.target.files.length; i++) {
      //       this.imageurls.push( {base64String: URL.createObjectURL( event.target.files[i]) });
      // }
      
      debugger; 
    console.log(this.imageurls);
    if (this.imageurls.length > 0) {
      localStorage.setItem('imgarray', JSON.stringify(this.imageurls));
      console.log(JSON.parse(localStorage.getItem('imgarray') ?? ""));
    }
    }
    
    
  }

  onSubmit() {
    if (this.resortForm.valid) {
      const newResort: ResortViewModel = this.resortForm.value;
      newResort.price = Number(newResort.price);
      newResort.capacity = Number(newResort.capacity);
      newResort.facilitiesIds = this.selectedFacilitiesIds;
      newResort.userId = JSON.parse(localStorage.getItem('user') ?? "").id;
      console.log(newResort);
      this.resortService.createResort(newResort).subscribe(
        () => {this.router.navigate(['/user'])}
      )
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

    if (this.resortForm.controls['districtId'].hasError('required')) {
      return 'You must enter a value';
    }

    return '';
  }

  getLocationErrorMessage(){

    if (this.resortForm.controls['locationId'].hasError('required')) {
      return 'You must enter a value';
    }

    return '';
  }
}
