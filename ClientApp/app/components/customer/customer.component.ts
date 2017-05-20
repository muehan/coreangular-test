import { Component } from '@angular/core';
import { CustomerApi } from '../../provider/api/api';
import { Customer } from '../../provider/model/models';
import { Observable } from 'rxjs/Observable';

@Component({
    selector: 'customer',
    templateUrl: './customer.component.html',
    providers: [CustomerApi]
})

export class CustomerComponent {

    public customers: Observable<Array<Customer>>;

    constructor(customerApi: CustomerApi) {
        this.customers = customerApi.apiCustomerGetAllGet();
    }
    
}
