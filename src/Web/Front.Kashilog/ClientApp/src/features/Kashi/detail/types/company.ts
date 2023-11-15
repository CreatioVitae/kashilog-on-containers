export class Company {
    name: string;
    zipCode: string;
    country: string;
    city: string;
    address: string;
    telephoneNumber: string;

    constructor(name: string, zipCode: string, country: string, city: string, address: string, telephoneNumber: string) {
        this.name = name;
        this.zipCode = zipCode;
        this.country = country;
        this.city = city;
        this.address = address;
        this.telephoneNumber = telephoneNumber;
    }

    public static validateAndGetAvailableValue(target: any): { validateResult: boolean, company: Company | null } {
        if (!(Object.hasOwn(target, 'companyName') &&
            Object.hasOwn(target, 'zipCode') &&
            Object.hasOwn(target, 'country') &&
            Object.hasOwn(target, 'city') &&
            Object.hasOwn(target, 'address') &&
            Object.hasOwn(target, 'telephoneNumber')
        )) {
            return { validateResult: false, company: null };
        }

        return {
            validateResult: true,
            company: new Company(
                target.companyName,
                target.zipCode,
                target.country,
                target.city,
                target.address,
                target.telephoneNumber
            )
        };
    }
}
