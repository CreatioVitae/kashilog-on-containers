import { Product } from "./Product";

export class SearchCondition {
    id: number | null;
    productName: string | null;

    constructor(id: number | null, productName: string | null) {
        this.id = id;
        this.productName = productName;
    }

    public static filterByFilteringCriteria(products: Product[], searchCondition: SearchCondition): Product[] {
        if (searchCondition.id != null) {
            products = products.filter(product => product.id == searchCondition.id);
        }

        if (searchCondition.productName != null && searchCondition.productName.length > 0) {
            products = products.filter(product => product.name.indexOf(searchCondition.productName as string) >= 0);
        }

        return products;
    }

    public static createDefault = () => new SearchCondition(null, null);

    public static recreate(oldCriteria: SearchCondition, newValue: string, target: string) {
        switch (target) {
            case 'id': {
                return new SearchCondition(newValue.length == 0 ? null : Number.parseInt(newValue), oldCriteria.productName);
            };
            case 'productName': {
                return new SearchCondition(oldCriteria.id, newValue.length == 0 ? null : newValue);
            };
            default: return SearchCondition.createDefault();
        }
    }
}
