import { Product } from "./Product";

export class OrderCondition {
    orderKey: string | null;
    order: Order | null

    constructor(orderKey: string | null, order: Order | null) {
        this.orderKey = orderKey;
        this.order = order;
    }

    public getOrderText = (target: string) => {
        if (this.orderKey != target) {
            return '';
        }

        if (this.order == Order.Asc) {
            return '▼';
        }

        if (this.order == Order.Desc) {
            return '▲';
        }

        return '';
    }

    public static orderBy = (products: Array<Product> | null, orderCondition: OrderCondition) => {
        if (products == null) {
            return products;
        }

        switch (orderCondition.order) {
            case Order.Asc:
                return this.orderByAsc(products, orderCondition.orderKey).map(e => e);
            case Order.Desc:
                return this.orderByDesc(products, orderCondition.orderKey).map(e => e);
            default:
                return products;
        }
    }

    public static orderByAsc = (products: Array<Product>, orderKey: string | null) => {
        switch (orderKey) {
            case 'id':
                return products.sort((a, b) => {
                    if (a.id > b.id) {
                        return 1;
                    }

                    if (a.id < b.id) {
                        return -1;
                    }

                    return 0;
                });
            case 'name':
                return products.sort((a, b) => {
                    if (a.name > b.name) {
                        return 1;
                    }

                    if (a.name < b.name) {
                        return -1;
                    }

                    return 0;
                });
            default:
                return products
        }
    }

    public static orderByDesc = (products: Array<Product>, orderKey: string | null) => {
        switch (orderKey) {
            case 'id':
                return products.sort((a, b) => {
                    if (a.id > b.id) {
                        return -1;
                    }

                    if (a.id < b.id) {
                        return 1;
                    }

                    return 0;
                });
            case 'name':
                return products.sort((a, b) => {
                    if (a.name > b.name) {
                        return -1;
                    }

                    if (a.name < b.name) {
                        return 1;
                    }

                    return 0;
                });
            default:
                return products
        }
    }

    public static createDefault = () => new OrderCondition(null, null);

    public static recreate = (orderCondition: OrderCondition, target: string) =>
        new OrderCondition(target, (orderCondition.order == null || orderCondition.order == Order.Desc) ? Order.Asc : Order.Desc);
}

export enum Order {
    Asc = 'Asc',
    Desc = 'Desc'
}
