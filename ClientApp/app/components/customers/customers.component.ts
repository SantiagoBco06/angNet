import { Component, Inject} from '@angular/core';

import { Http } from '@angular/http';

@Component({
    selector: 'customers',
    templateUrl: './customers.component.html'
})
export class CustomersComponent {
    public customers: Customer[];

    constructor( http:Http, @Inject('ORIGIN_URL') originUrl: string ) {

        http.get(originUrl + '/api/Actor/ListCustomer').subscribe(result => {
            this.customers = result.json() as Customer[];
            console.log(this.customers);
        });

    }
    

}

interface Customer {
    customer_id: number;
    first_name: string;
    last_name: string;
    email: string;
    last_update: string;
    address: Address;
}

interface Address {
    address_id: number;
    address: string;
    address2: string;
    phone: string;
}