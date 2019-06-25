import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-project-forecast',
  templateUrl: './project-forecast.component.html',
  styleUrls: ['./project-forecast.component.scss']
})
export class ProjectForecastComponent implements OnInit {

  startyear: number;
  currentyear: number;
  year1: number;
  year2: number;
  year3: number;
  year4: number;
  year5: number;
  year6: number;
  year7: number;
  year8: number;
  year9: number;
  year10: number;

  previous = false;
  current = false;
  future = false;

  constructor() { }

  ngOnInit() {

    this.startyear = 2000;
    this.currentyear = 2005;
    this.year1 = this.startyear;
    this.year2 = this.startyear + 1;
    this.year3 = this.startyear + 2;
    this.year4 = this.startyear + 3;
    this.year5 = this.startyear + 4;
    this.year6 = this.startyear + 5;
    this.year7 = this.startyear + 6;
    this.year8 = this.startyear + 7;
    this.year9 = this.startyear + 8;
    this.year10 = this.startyear + 9;

  }

  isPreviousyears(year) {

    if (this.currentyear > year) {
      return true;

    } else {
      return false;
    }

  }
  isCurrentyears(year) {

    if (this.currentyear === year) {
      return true;

    } else {
      return false;
    }

  }
  isFutureyears(year) {

    if (this.currentyear < year) {
      return true;

    } else {
      return false;
    }

  }

}
