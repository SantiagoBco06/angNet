import { Component, Inject } from '@angular/core';

import { Http } from '@angular/http';

@Component({
    selector: 'actors',
    templateUrl: './actors.component.html'
})
export class ActorsComponent {
    public actors: Actor[];

    constructor( http:Http, @Inject('ORIGIN_URL') originUrl: string ) {

        http.get(originUrl + '/api/Actor/Index').subscribe(result => {
            this.actors = result.json() as Actor[];
        });

    }
    
}

interface Actor {
    actor_id: number;
    first_name: string;
    last_name: string;
    last_update: string;
}