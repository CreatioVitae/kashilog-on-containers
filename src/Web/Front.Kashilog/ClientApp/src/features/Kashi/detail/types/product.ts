import { Company } from "./company";
import { Taste } from "./taste";
import { Texture } from "./texture";

export class Product {
    id: number;
    name: string;
    largeCategory: string;
    middleCategory: string;
    smallCategory: string;
    unitPrice: number;
    amount: number;
    amountType: string;
    description: string;
    maker: Company;
    textures: Array<Texture>;
    tastes: Array<Taste>;

    constructor(id: number, name: string, largeCategory: string, middleCategory: string, smallCategory: string, unitPrice: number, amount: number, amountType: string,
        description: string, maker: Company, textures: Array<Texture>, tastes: Array<Taste>) {
        this.id = id;
        this.name = name;
        this.largeCategory = largeCategory;
        this.middleCategory = middleCategory;
        this.smallCategory = smallCategory;
        this.unitPrice = unitPrice;
        this.amount = amount;
        this.amountType = amountType;
        this.description = description;
        this.maker = maker;
        this.textures = textures;
        this.tastes = tastes;
    }

    public static validateAndGetAvailableValue(target: any): { validateResult: boolean, product: Product | null } {
        if (!(Object.hasOwn(target, 'productId') &&
            Object.hasOwn(target, 'productName') &&
            Object.hasOwn(target, 'largeCategory') &&
            Object.hasOwn(target, 'middleCategory') &&
            Object.hasOwn(target, 'smallCategory') &&
            Object.hasOwn(target, 'unitPrice') &&
            Object.hasOwn(target, 'amount') &&
            Object.hasOwn(target, 'amountType') &&
            Object.hasOwn(target, 'description') &&
            Object.hasOwn(target, 'maker') &&
            Object.hasOwn(target, 'textures') &&
            Object.hasOwn(target, 'tastes')
        )) {
            return { validateResult: false, product: null };
        }

        if (
            isNaN(target.productId) ||
            isNaN(target.unitPrice) ||
            isNaN(target.amount)
        ) {
            return { validateResult: false, product: null };
        }

        const { validateResult: makerValidateResult, company: maker } = Company.validateAndGetAvailableValue(target.maker);

        if (makerValidateResult == false || maker == null) {
            return { validateResult: false, product: null };
        }

        const { validateResult: texturesValidateResult, textures } = Texture.validateAndGetAvailableValues(target.textures);

        if (texturesValidateResult == false || textures == null) {
            return { validateResult: false, product: null };
        }

        const { validateResult: tastesValidateResult, tastes } = Taste.validateAndGetAvailableValues(target.tastes);

        if (tastesValidateResult == false || tastes == null) {
            return { validateResult: false, product: null };
        }

        return {
            validateResult: true,
            product: new Product(
                Number.parseInt(target.productId),
                target.productName,
                target.largeCategory,
                target.middleCategory,
                target.smallCategory,
                Number.parseInt(target.unitPrice),
                Number.parseInt(target.amount),
                target.amountType,
                target.description,
                maker,
                textures,
                tastes
            )
        };
    }
}
