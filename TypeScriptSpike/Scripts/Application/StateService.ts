module lasl321.Services {
    export class LeadInformation {
        private _firstName: string;
        private _lastName: string;

        get firstName (): string {
            return this._firstName;
        }

        get lastName (): string {
            return this._lastName;
        }
    }

    export class Procedure {
    }

    export class Carrier {
    }

    export class Plan {
    }

    export class Availability {
        constructor (public timeSlotId: number) {}
    }

    export class Age {
        constructor (public isOver21: boolean, public age: number) {}
    }

    export class StateService {
        private _procedure: Procedure;
        private _carrier: Carrier;
        private _plan: Plan;
        private _availability: Availability;
        private _age: Age;
        private _leadInformation: LeadInformation;
        private _campaignId: number;
        private _visitId: number;
        private _contractId: number;

        get procedure (): Procedure { return this._procedure; }

        set procedure (procedure: Procedure) { this._procedure = procedure; }

        get leadInformation (): LeadInformation { return this._leadInformation; }
    }
}