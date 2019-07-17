import { Component, OnInit, Input } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-delete-resource',
  templateUrl: './delete-resource.component.html',
  styleUrls: ['./resource.component.scss']
})
export class DeleteResourceComponent implements OnInit {

  @Input() id;

  constructor(public activeModal: NgbActiveModal) { }

  ngOnInit() {
  }

}
