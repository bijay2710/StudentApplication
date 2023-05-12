import { Component } from '@angular/core';
import 'devextreme/data/odata/store';

@Component({
  templateUrl: 'tasks.component.html'
})

export class TasksComponent {
   yourData = [
    { AddressType: 'Primary', AddressLine1: '123 Anywhere Avenue', AddressLine2: 'Suite 100',AddressLine3:'', StateProvince: 'TX',PostalCode: '75220',Country: 'USA',Phone: '213-512-5100',EmailAddress:"volvogroup@volvogrou.com",Status:"Active"},
    { AddressType: 'Bill To', AddressLine1: '123 Anywhere Avenue', AddressLine2: 'Suite 200',AddressLine3:'', StateProvince: 'TX',PostalCode: '75220',Country: 'USA',Phone: '213-512-5105',EmailAddress:"ap@volvogrou.com",Status:"Active"},

  ];
}
