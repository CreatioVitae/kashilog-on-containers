import { SearchCondition } from "../types/SearchCondition";
import { Product } from "../types/Product";
import GlobalSettings from "../../../../config/GlobalSettings";

const globalSettings = new GlobalSettings();

const getKashiList = (searchCondition: SearchCondition) => {
    const url = `${globalSettings.apiUrl}Product`;

    return fetch(url)
        .then((res) => {
            if (res.status != 200) {
                return;
            }
            return res.json()
        })
        .then((products) => {
            let mapedProducts = mapProducts(products);
            if (searchCondition != null && mapedProducts != null) {
                return SearchCondition.filterByFilteringCriteria(mapedProducts, searchCondition);
            }
            return mapedProducts;
        });
}

const mapProducts = (products: any): Array<Product> | null => {
    if (products.length == 0) {
        return null;
    }

    return products.map((product: any) => {
        const { validateResult, product: availableProduct } = Product.validateAndGetAvailableValue(product);

        if (validateResult && availableProduct != null) {
            return availableProduct;
        }
    });
}

export { getKashiList }
