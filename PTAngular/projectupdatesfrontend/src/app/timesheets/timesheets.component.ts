import { Component, OnInit, ElementRef, HostListener, ViewChild, AfterViewInit, Renderer2, OnDestroy } from '@angular/core';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';

// import { LayoutService } from '../services/layout.service';
import { Subscription } from 'rxjs';
import { LayoutService } from 'app/shared/services/layout.service';
import { ConfigService } from 'app/shared/services/config.service';
import { TimesheetsService } from './timesheets.service';
import { Mail, Message, TimesheetTotals } from './timesheets.model';

// import { ConfigService } from '../services/config.service';

@Component({
  selector: 'app-timesheets',
  templateUrl: './timesheets.component.html',
  styleUrls: ['./timesheets.component.scss'],
  // providers: [TimesheetsService]
})
export class TimesheetsComponent implements OnInit, AfterViewInit, OnDestroy {

  placement = 'bottom-right';
  public innerWidth: any;

  public config: any = {};
  layoutSub: Subscription;


  @ViewChild('emailSidebar') sidebar: ElementRef;
  @ViewChild('contentOverlay') overlay: ElementRef;
  @ViewChild('emailContent') content: ElementRef;

  searchQuery = '';
  selectedMailId = 4;
  isEmailImportant = false;
  public isCollapsed = true;
  public isCollapsed1 = false;
  public isMessageSelected = true;
  closeResult: string;
  mail: Mail[];
  timesheets: TimesheetTotals[] = [];
  message: Message;
  constructor(private elRef: ElementRef, private renderer: Renderer2,
    private modalService: NgbModal, private timesheetsService: TimesheetsService,
    private layoutService: LayoutService, private configService: ConfigService) {

      this.timesheetsService.getTimesheets();
    setTimeout(() => {this.timesheets = this.timesheetsService.timesheetsData; }, 1500);

    this.mail = this.timesheetsService.timesheets.filter((mail: Mail) => mail.mailType === 'Inbox');
    this.message = this.timesheetsService.message.filter((message: Message) => message.mailId === this.selectedMailId)[0];
    this.markAsRead();
    this.checkEmailImportantStatus();

    this.layoutSub = layoutService.changeEmitted$.subscribe(
      direction => {
        const dir = direction.direction;
        if (dir === 'rtl') {
          this.placement = 'bottom-left';
        } else if (dir === 'ltr') {
          this.placement = 'bottom-right';
        }
      });
  }

  ngOnInit() {
    this.innerWidth = window.innerWidth;
    this.config = this.configService.templateConf;

    this.timesheetsService.getTimesheets();
    setTimeout(() => {this.timesheets = this.timesheetsService.timesheetsData;
      this.selectedMailId = this.timesheets[0].calendarTimeId; }, 1500);


    // this.timesheetsService.alltimesheets.subscribe(timesheets => {
    //   // tslint:disable-next-line:curly
    //   if (timesheets.length === 0) return;

    //   setTimeout(() => {
    //     this.timesheets = timesheets;
    //     }, 250);
    // });

    console.log(this.timesheets);
  }

  ngAfterViewInit() {
    if (this.innerWidth < 768) {
      this.renderer.addClass(this.content.nativeElement, 'hide-email-content');
    }

    if (this.config.layout.dir) {
      const dir = this.config.layout.dir;
        if (dir === 'rtl') {
          this.placement = 'bottom-left';
        } else if (dir === 'ltr') {
          this.placement = 'bottom-right';
        }
    }
  }

  ngOnDestroy() {
    if (this.layoutSub) {
      this.layoutSub.unsubscribe();
    }
  }

  markAsRead() {
    const updateItem = this.mail.find(item => item.mailId.toString() === this.selectedMailId.toString());
    const index = this.mail.indexOf(updateItem);
    this.mail[index].isRead = true;
  }

  markAsUnread() {
    const updateItem = this.mail.find(item => item.mailId.toString() === this.selectedMailId.toString());
    const index = this.mail.indexOf(updateItem);
    this.mail[index].isRead = false;
  }

  markAsImportant() {
    const updateItem = this.mail.find(item => item.mailId.toString() === this.selectedMailId.toString());
    const index = this.mail.indexOf(updateItem);
    this.mail[index].isImportant = true;
    this.isEmailImportant = true;
  }

  markAsUnimportant() {
    const updateItem = this.mail.find(item => item.mailId.toString() === this.selectedMailId.toString());
    const index = this.mail.indexOf(updateItem);
    this.mail[index].isImportant = false;
    this.isEmailImportant = false;
  }

  checkEmailImportantStatus() {
    const selectedEmail = this.mail.find(item => item.mailId.toString() === this.selectedMailId.toString());
    this.isEmailImportant = selectedEmail.isImportant;
  }



  // timesheets user list click event function
  DisplayMessage(event, mailId: number) {
    this.selectedMailId = mailId;
    this.message = this.timesheetsService.message.filter((message: Message) => message.mailId.toString() === mailId.toString())[0];
    this.isMessageSelected = true;
    this.markAsRead();
    this.checkEmailImportantStatus();

    const hElement: HTMLElement = this.elRef.nativeElement;
    // now you can simply get your elements with their class name
    const allAnchors = hElement.querySelectorAll('.users-list-padding > a.list-group-item');
    // do something with selected elements
    [].forEach.call(allAnchors, function (item: HTMLElement) {
      item.setAttribute('class', 'list-group-item list-group-item-action no-border');
    });
    // set active class for selected item
    event.currentTarget.setAttribute('class', 'list-group-item list-group-item-action bg-blue-grey bg-lighten-5 border-right-primary border-right-2');

  }

  // compose popup start
  open(content) {
    this.modalService.open(content, { size: 'lg' }).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }
  // compose popup ends

  // timesheets labels click event function
  GetEmailsByLabel(event, labelType: string) {
    this.mail = this.timesheetsService.timesheets.filter((mail: Mail) => mail.labelType === labelType);
    this.SetItemActive(event);
  }

  // timesheets type click event function
  GetEmailsByType(event, type: string) {
    this.mail = this.timesheetsService.timesheets.filter((mail: Mail) => mail.mailType === type)
    this.SetItemActive(event);
  }

  // timesheets Starred click event function
  GetStarredEmails(event) {
    this.mail = this.timesheetsService.timesheets.filter((mail: Mail) => mail.isImportant === true);
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

  @HostListener('window:resize', ['$event'])
  onResize(event) {
    this.innerWidth = window.innerWidth;
    if (this.innerWidth < 768) {
      this.renderer.addClass(this.content.nativeElement, 'hide-email-content');
    }
    if (this.innerWidth > 768) {
      this.renderer.removeClass(this.content.nativeElement, 'hide-email-content');
    }
  }

  onListItemClick() {
    this.renderer.removeClass(this.content.nativeElement, 'hide-email-content');
  }

  OnBackTotimesheets() {
    this.renderer.addClass(this.content.nativeElement, 'hide-email-content');
  }

  onSidebarToggle() {
    this.renderer.removeClass(this.sidebar.nativeElement, 'd-none');
    this.renderer.addClass(this.sidebar.nativeElement, 'd-block');
    this.renderer.addClass(this.overlay.nativeElement, 'show');
  }

  onContentOverlay() {
    this.renderer.removeClass(this.overlay.nativeElement, 'show');
    this.renderer.removeClass(this.sidebar.nativeElement, 'd-block');
    this.renderer.addClass(this.sidebar.nativeElement, 'd-none');
  }


}
