import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-consultant',
  imports: [CommonModule, FormsModule],
  templateUrl: './consultant.html',
  styleUrl: './consultant.css',
})
export class Consultant {
  searchText = "";

  consultants = [

    {
      id:1,
      name:"John Mathew",
      email:"john@gmail.com",
      phone:"9876543210",
      experience:8,
      assignedTour:"Dubai Tour",
      status:"Available",
      photo:""
    },

    {
      id:2,
      name:"Maria Thomas",
      email:"maria@gmail.com",
      phone:"9876543211",
      experience:6,
      assignedTour:"Rome Tour",
      status:"Busy",
      photo:""
    },

    {
      id:3,
      name:"Rahul Nair",
      email:"rahul@gmail.com",
      phone:"9876543212",
      experience:3,
      assignedTour:"Santorini",
      status:"Inactive",
      photo:""
    },

    {
      id:4,
      name:"David Roy",
      email:"david@gmail.com",
      phone:"9876543213",
      experience:9,
      assignedTour:"Paris Tour",
      status:"Available",
      photo:""
    }

  ];

  get filteredConsultants() {

    return this.consultants.filter(c =>

      c.name.toLowerCase().includes(this.searchText.toLowerCase())

    );

  }

  viewProfile(name:string){

    alert("Viewing Profile of " + name);

  }
}
