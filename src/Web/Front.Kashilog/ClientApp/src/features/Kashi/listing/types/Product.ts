export class Product {
    id: number;
    revision: number;
    validBeginDateTime: string;
    validEndDateTime: string;
    name: string;
    largeCategory: string;
    middleCategory: string;
    smallCategory: string;
    unitPrice: number;
    amount: number;
    amountType: string;
    description: string;
    makerName: string;
    publisherName: string;

    constructor(id: number, revision: number, validBeginDateTime: string, validEndDateTime: string, name: string, largeCategory: string,
        middleCategory: string, smallCategory: string, unitPrice: number, amount: number, amountType: string, description: string, makerName: string, publisherName: string) {
        this.id = id;
        this.revision = revision;
        this.validBeginDateTime = validBeginDateTime;
        this.validEndDateTime = validEndDateTime;
        this.name = name;
        this.largeCategory = largeCategory;
        this.middleCategory = middleCategory;
        this.smallCategory = smallCategory;
        this.unitPrice = unitPrice;
        this.amount = amount;
        this.amountType = amountType;
        this.description = description;
        this.makerName = makerName;
        this.publisherName = publisherName;
    }

    public static validateAndGetAvailableValue(target: any): { validateResult: boolean, product: Product | null } {
        if (!(Object.hasOwn(target, 'productId') &&
            Object.hasOwn(target, 'productRevision') &&
            Object.hasOwn(target, 'validBeginDateTime') &&
            Object.hasOwn(target, 'validEndDateTime') &&
            Object.hasOwn(target, 'productName') &&
            Object.hasOwn(target, 'largeCategory') &&
            Object.hasOwn(target, 'middleCategory') &&
            Object.hasOwn(target, 'smallCategory') &&
            Object.hasOwn(target, 'unitPrice') &&
            Object.hasOwn(target, 'amount') &&
            Object.hasOwn(target, 'amountType') &&
            Object.hasOwn(target, 'description') &&
            Object.hasOwn(target, 'maker') &&
            Object.hasOwn(target.maker, 'companyName') &&
            Object.hasOwn(target, 'publisher') &&
            Object.hasOwn(target.publisher, 'companyName')
        )) {
            return { validateResult: false, product: null };
        }

        if (
            isNaN(target.productId) ||
            isNaN(target.productRevision) ||
            isNaN(target.unitPrice) ||
            isNaN(target.amount)
        ) {
            return { validateResult: false, product: null };
        }

        return {
            validateResult: true,
            product: new Product(
                Number.parseInt(target.productId),
                Number.parseInt(target.productRevision),
                target.validBeginDateTime,
                target.validEndDateTime,
                target.productName,
                target.largeCategory,
                target.middleCategory,
                target.smallCategory,
                Number.parseInt(target.unitPrice),
                Number.parseInt(target.amount),
                target.amountType,
                target.description,
                target.maker.companyName,
                target.publisher.companyName
            )
        };
    }
}
