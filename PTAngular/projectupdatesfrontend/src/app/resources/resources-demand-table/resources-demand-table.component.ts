import { Component, OnInit, ViewChild } from '@angular/core';
import { ChartEvent, ChartType } from 'ng-chartist';
import * as Chartist from 'chartist';
import { Subject } from 'rxjs';


@Component({
  selector: 'app-resources-demand-table',
  templateUrl: './resources-demand-table.component.html',
  styleUrls: ['./resources-demand-table.component.scss']
})
export class ResourcesDemandTableComponent implements OnInit {

  @ViewChild('exampleTableTools') table;
  dtOptions: any = {};
  example: any;
  // dtOptions: DataTables.Settings = {};
  dtTrigger: Subject<any> = new Subject();


  // constructor() { }

  ngOnInit() {
    this.dtOptions = {

      pagingType: 'full_numbers',
      pageLength: 100,
      processing: true,
      'paging':   true,
      'ordering': true,
      'info':     true,

      'columnDefs':
      [ {
          'targets': [3],
          'visible': true,
          'searchable': true
        },

        {
        'targets': [4],
        'visible': true
        }
          // ,{ 'bSortable': true, 'bSort': false, 'aTargets': [ '_all' ] }
      ],

      // responsive: true,
      searching: true,
      select: true,
      order: [0, 'desc'],
      dom: `<
             <"row"
               <"col-lg-3 col-md-12"l>
               <"col-lg-6 col-md-12 button-wrapper btn-sm danger"B>
               <"col-lg-3 col-md-12"f>><hr>
             <"row" <"col"t>>
             <"row"
               <"col"i>
               <"col btn-sm"p>>
             >`,

      buttons: [
      'copy', 'csv', 'excel', 'pdf', 'print',
        {
          text: 'GroupBy',
          key: '1',
          action: function (e, dt, node, config) {
            alert('Button activated');
          }
        },
        {
          text: 'Some button',
          key: '1',
          action: function (e, dt, node, config) {
            alert('Button activated');
          }
        },
        {
          text: 'Some button',
          key: '1',
          action: function (e, dt, node, config) {
            alert('Button activated');
          }
        },

      ],
      'bLengthChange': true,
      'Filter': true,
      'Info': true,
      fixedHeader: {
        header: true,
        bottom: true,
        // footer: false,
        zTop: 1000
        // headerOffset: 400

      },

    };

    this.example = $(this.table.nativeElement);
    this.example.DataTable(this.dtOptions);

  }

}
