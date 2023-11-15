import { Product } from "../types/product";
import GlobalSettings from "../../../../config/GlobalSettings";

const globalSettings = new GlobalSettings();

const getKashi = (id: number) => {
    const url = `${globalSettings.apiUrl}Product/${id}`;

    return fetch(url)
        .then((res) => {
            if (res.status != 200) {
                return;
            }
            return res.json()
        })
        .then((products) => {
            let mapedProducts = mapProducts(products);

            return mapedProducts;
        });
}

const mapProducts = (product: any): Product | null => {
    const { product: availableProduct } = Product.validateAndGetAvailableValue(product);
     
    return availableProduct;
}

export { getKashi }
