import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-home',
  imports: [FormsModule,CommonModule],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {
  studentName = "";
  names = ['Ansh','abhi'];
  clicked = false;
  handleClick(){
    this.clicked = true;
  }
  addName() {
    if (this.studentName.trim()) {
      this.names.push(this.studentName.trim());
      this.studentName = ''; // clear input
    }
  }

}