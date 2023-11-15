import React, { useEffect, useMemo, useState } from 'react';
import Filter from './Filter';
import { SearchCondition } from '../types/SearchCondition';
import Kashi from './Kashi';
import { Product } from '../types/Product';
import { getKashiList } from '../api/getKashiList';
import { css, StyleSheet } from 'aphrodite';
import { OrderCondition } from '../types/OrderCondition';

const KashiList = () => {
    const [products, setProducts] = useState<Array<Product> | null>(null);
    const [searchCondition, setSearchCondition] = useState<SearchCondition>(SearchCondition.createDefault());
    const [orderCondition, setOrderCondition] = useState<OrderCondition>(OrderCondition.createDefault());

    const getProducts = useMemo(async() => {
        const productsFromApi = await getKashiList(searchCondition);

        setProducts(OrderCondition.orderBy(productsFromApi, orderCondition));
    }, [searchCondition]);

    useEffect(() => {
        setProducts(OrderCondition.orderBy(products, orderCondition));
    }, [orderCondition]);

    getProducts;

    const style = StyleSheet.create({
        listContainer: {
            display: 'flex',
            flexWrap: 'wrap',
            alignContent: 'space-around'
        }
    });

    return (
        <>
            <Filter searchCondition={searchCondition} setSearchCondition={setSearchCondition} orderCondition={orderCondition} setOrderCondition={setOrderCondition} />
            <div className={css(style.listContainer)}>
                {products == null ? null :
                    products.map((product) => {
                    return (
                        <Kashi product={product} key={product.id} />
                    );
                })}
            </div>
        </>
    );
}

export default KashiList;
