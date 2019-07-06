import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-support-how-to-do-guide',
  templateUrl: './support-how-to-do-guide.component.html',
  styleUrls: ['./support-how-to-do-guide.component.scss']
})
export class SupportHowToDoGuideComponent implements OnInit {

  title: string;
  constructor(private modalService: NgbModal) {}


  GetDetails(content, titleText) {
    this.title = titleText;
    this.modalService.open(content, { size: 'lg' }).result.then((result) => {
    }, (reason) => {
    });
  }

  ngOnInit() {
  }

}
