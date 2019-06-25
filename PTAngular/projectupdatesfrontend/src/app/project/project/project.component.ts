import { Component, OnInit, ElementRef } from '@angular/core';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.scss']
})
export class ProjectComponent implements OnInit {

  displayDashboard = true;
  displayForecast = false;
  displayActual = false;
  displayBudget = false;
  displayMilestone = false;
  displayActionlog = false;
  displayRisk = false;
  displayAssumption = false;
  displayIssue = false;
  displayDependency = false;
  displayRag = false;

  constructor(private elRef: ElementRef) { }

  ngOnInit() {
  }

  // inbox type click event function
  GetElement(event, type: string) {

    if (type === 'Dashboard') {
      this.displayDashboard = true;
      this.displayForecast = false;
      this.displayActual = false;
      this.displayBudget = false;
      this.displayMilestone = false;
      this.displayActionlog = false;
      this.displayRisk = false;
      this.displayAssumption = false;
      this.displayIssue = false;
      this.displayDependency = false;
      this.displayRag = false;

    }
    if (type === 'Forecast') {
      this.displayDashboard = false;
      this.displayForecast = true;
      this.displayActual = false;
      this.displayBudget = false;
      this.displayMilestone = false;
      this.displayActionlog = false;
      this.displayRisk = false;
      this.displayAssumption = false;
      this.displayIssue = false;
      this.displayDependency = false;
      this.displayRag = false;

    }
    if (type === 'Actual') {
      this.displayDashboard = false;
      this.displayForecast = false;
      this.displayActual = true;
      this.displayBudget = false;
      this.displayMilestone = false;
      this.displayActionlog = false;
      this.displayRisk = false;
      this.displayAssumption = false;
      this.displayIssue = false;
      this.displayDependency = false;
      this.displayRag = false;

    }
    if (type === 'Budget') {
      this.displayDashboard = false;
      this.displayForecast = false;
      this.displayActual = false;
      this.displayBudget = true;
      this.displayMilestone = false;
      this.displayActionlog = false;
      this.displayRisk = false;
      this.displayAssumption = false;
      this.displayIssue = false;
      this.displayDependency = false;
      this.displayRag = false;

    }
    if (type === 'Milestones') {
      this.displayDashboard = false;
      this.displayForecast = false;
      this.displayActual = false;
      this.displayBudget = false;
      this.displayMilestone = true;
      this.displayActionlog = false;
      this.displayRisk = false;
      this.displayAssumption = false;
      this.displayIssue = false;
      this.displayDependency = false;
      this.displayRag = false;

    }
    if (type === 'Actions') {
      this.displayDashboard = false;
      this.displayForecast = false;
      this.displayActual = false;
      this.displayBudget = false;
      this.displayMilestone = false;
      this.displayActionlog = true;
      this.displayRisk = false;
      this.displayAssumption = false;
      this.displayIssue = false;
      this.displayDependency = false;
      this.displayRag = false;

    }
    if (type === 'Risks') {
      this.displayDashboard = false;
      this.displayForecast = false;
      this.displayActual = false;
      this.displayBudget = false;
      this.displayMilestone = false;
      this.displayActionlog = false;
      this.displayRisk = true;
      this.displayAssumption = false;
      this.displayIssue = false;
      this.displayDependency = false;
      this.displayRag = false;

    }
    if (type === 'Assumptions') {
      this.displayDashboard = false;
      this.displayForecast = false;
      this.displayActual = false;
      this.displayBudget = false;
      this.displayMilestone = false;
      this.displayActionlog = false;
      this.displayRisk = false;
      this.displayAssumption = true;
      this.displayIssue = false;
      this.displayDependency = false;
      this.displayRag = false;

    }
    if (type === 'Issues') {
      this.displayDashboard = false;
      this.displayForecast = false;
      this.displayActual = false;
      this.displayBudget = false;
      this.displayMilestone = false;
      this.displayActionlog = false;
      this.displayRisk = false;
      this.displayAssumption = false;
      this.displayIssue = true;
      this.displayDependency = false;
      this.displayRag = false;

    }
    if (type === 'Dependencies') {
      this.displayDashboard = false;
      this.displayForecast = false;
      this.displayActual = false;
      this.displayBudget = false;
      this.displayMilestone = false;
      this.displayActionlog = false;
      this.displayRisk = false;
      this.displayAssumption = false;
      this.displayIssue = false;
      this.displayDependency = true;
      this.displayRag = false;

    }

    this.SetItemActive(event);

  }

  SetItemActive(event) {

    const hElement: HTMLElement = this.elRef.nativeElement;
    // now you can simply get your elements with their class name
    const allAnchors = hElement.querySelectorAll('.list-group-messages > a.list-group-item');
    // do something with selected elements
    [].forEach.call(allAnchors, function (item: HTMLElement) {
      item.setAttribute('class', 'list-group-item list-group-item-action no-border');
    });
    // set active class for selected item
    event.currentTarget.setAttribute('class', 'list-group-item active no-border');
  }

}
