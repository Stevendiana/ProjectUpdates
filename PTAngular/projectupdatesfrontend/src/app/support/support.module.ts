import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SupportHowToDoGuideComponent } from './support-how-to-do-guide/support-how-to-do-guide.component';
import { SupportRoutingModule } from './support-routing.module';
import { ChartistModule } from 'ng-chartist';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MatchHeightModule } from 'app/shared/directives/match-height.directive';

@NgModule({
  declarations: [SupportHowToDoGuideComponent],
  imports: [
    CommonModule,
    SupportRoutingModule,
    ChartistModule,
    NgbModule,
    MatchHeightModule
  ]
})
export class SupportModule { }
