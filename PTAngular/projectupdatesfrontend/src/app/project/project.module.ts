import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProjectRoutingModule } from './project-routing.module';
import { ProjectDashboardComponent } from './project-dashboard/project-dashboard.component';
import { ProjectRagComponent } from './project-rag/project-rag.component';
import { ProjectRiskComponent } from './project-risk/project-risk.component';
import { ProjectAssumptionComponent } from './project-assumption/project-assumption.component';
import { ProjectIssueComponent } from './project-issue/project-issue.component';
import { ProjectDependencyComponent } from './project-dependency/project-dependency.component';
import { ProjectActionLogComponent } from './project-action-log/project-action-log.component';
import { ProjectComponent } from './project/project.component';
import { ProjectMilestoneComponent } from './project-milestone/project-milestone.component';
import { ProjectBudgetComponent } from './project-budget/project-budget.component';
import { HttpModule } from '@angular/http';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { InboxModule } from 'app/inbox/inbox.module';
import { FormsModule } from '@angular/forms';
import { QuillModule } from 'ngx-quill';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { DashboardModule } from 'app/dashboard/dashboard.module';
import { ProjectActualComponent } from './project-actual/project-actual.component';
import { ProjectForecastComponent } from './project-forecast/project-forecast.component';
import { ProjectForecastPreviousyearComponent } from './project-forecast-previousyear/project-forecast-previousyear.component';
import { ProjectForecastCurrentyearComponent } from './project-forecast-currentyear/project-forecast-currentyear.component';
import { ProjectForecastFutureyearComponent } from './project-forecast-futureyear/project-forecast-futureyear.component';
import { ProjectBudgetFutureyearComponent } from './project-budget-futureyear/project-budget-futureyear.component';
import { ProjectBudgetCurrentyearComponent } from './project-budget-currentyear/project-budget-currentyear.component';
import { ProjectBudgetPreviousyearComponent } from './project-budget-previousyear/project-budget-previousyear.component';

@NgModule({
  declarations: [
                 ProjectDashboardComponent,
                 ProjectRagComponent,
                 ProjectRiskComponent,
                 ProjectAssumptionComponent,
                 ProjectIssueComponent,
                 ProjectDependencyComponent,
                 ProjectActionLogComponent,
                 ProjectComponent,
                 ProjectMilestoneComponent,
                 ProjectBudgetComponent,
                 ProjectActualComponent,
                 ProjectForecastComponent,
                 ProjectForecastPreviousyearComponent,
                 ProjectForecastCurrentyearComponent,
                 ProjectForecastFutureyearComponent,
                 ProjectBudgetFutureyearComponent,
                 ProjectBudgetCurrentyearComponent,
                 ProjectBudgetPreviousyearComponent],
  imports: [
    CommonModule,
    HttpModule,
    ProjectRoutingModule,
    NgbModule,
    QuillModule,
    FormsModule,
    InboxModule,
    DashboardModule,
    PerfectScrollbarModule,
  ]
})
export class ProjectModule { }
