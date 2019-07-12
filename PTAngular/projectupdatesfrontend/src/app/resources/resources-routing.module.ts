import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ResourcesComponent } from './resources/resources.component';
import { ResourcesAvailabilityComponent } from './resources-availability/resources-availability.component';
import { ResourcesUtilizationComponent } from './resources-utilization/resources-utilization.component';
import { ResourcesDemandComponent } from './resources-demand/resources-demand.component';
import { ResourcesDashboardComponent } from './resources-dashboard/resources-dashboard.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'dashbaord',
        component: ResourcesDashboardComponent,
        data: {
          title: 'Dashboard'
        }
      },
      {
        path: 'resources',
        component: ResourcesComponent,
        data: {
          title: 'Resource Pool'
        }
      },
      {
        path: 'demand',
        component: ResourcesDemandComponent,
        data: {
          title: 'Demand'
        }
      },
      {
        path: 'availability',
        component: ResourcesAvailabilityComponent,
        data: {
          title: 'Availability'
        }
      },
      {
        path: 'utilization',
        component: ResourcesUtilizationComponent,
        data: {
          title: 'Utilization'
        }
      },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ResourcesRoutingModule { }
// export const routedComponents = [ResourcesComponent];
