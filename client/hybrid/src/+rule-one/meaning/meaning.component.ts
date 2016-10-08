import { Component, OnInit, Input } from '@angular/core';

import { MeaningService } from './meaning.service';
import { Meaning } from './meaning.model';

@Component({
    selector: 'meaning-to-you',
    templateUrl: 'meaning.component.html',
})
export class MeaningComponent implements OnInit {
    @Input() companySymbol: string;
    public meaning: Meaning;

    constructor(public meaningService: MeaningService) {
        this.meaning = new Meaning(); 
    }

    ngOnInit() {
        this.meaningService.getMeaning(this.companySymbol, 'c6c746fd-e2da-4f3b-8417-6b7716421133').then(meaning => {
            this.meaning = meaning;
        });
    }
}