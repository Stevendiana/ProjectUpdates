import { Component, OnInit, Input } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-new-resource',
  templateUrl: './new-resource.component.html',
  styleUrls: ['./new-resource.component.scss']
})
export class NewResourceComponent implements OnInit {

  @Input() name;

  constructor(public activeModal: NgbActiveModal) { }

  ngOnInit() {
  }

}
