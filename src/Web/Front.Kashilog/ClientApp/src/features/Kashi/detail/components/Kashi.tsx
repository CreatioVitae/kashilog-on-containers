import React, { Suspense, useMemo, useEffect, useState } from 'react';
import { Product } from '../types/product';
import { css, StyleSheet } from 'aphrodite';
import { getKashi } from '../api/getKashi';
import { useParams } from 'react-router-dom';
import { Link } from 'react-router-dom';
import ProductReport from './ProductReport';
import { TransitionGroup, CSSTransition } from 'react-transition-group';

const Kashi = () => {

    const [product, setProduct] = useState<Product | null>(null);
    const [prevProduct, setPrevProduct] = useState<Product | null>(null);
    const [nextProduct, setNextProduct] = useState<Product | null>(null);
    const [onAnimationBegin, setOnAnimationBegin] = useState<boolean>(false);

    let { id } = useParams();

    if (id == null || isNaN(Number.parseInt(id))) {
        return null;
    }

    useEffect(() => {
        setOnAnimationBegin(true);
        return (setOnAnimationBegin(false));
    },[id]);

    const getProduct = useMemo(async () => {
        const currentProductId = Number.parseInt(id as string);

        const current = await getKashi(currentProductId);

        setProduct(current);

        const previous = currentProductId - 1 > 0 ? await getKashi(currentProductId - 1) : null;

        setPrevProduct(previous);

        const next = await getKashi(currentProductId + 1);

        setNextProduct(next);
    },[id]);

    getProduct;

    const style = StyleSheet.create({
        product: {
            width: "100%",
            padding: "14px"
        },
        returnList: {
            paddingBottom: "20px"
        },
        fadeEnter: {
            opacity: 0
        },
        fadeEnterActive: {
            transition: "all 1000ms ease-out",
            opacity: 1
        },
        fadeEnterDone: {
            opacity: 1
        },
        fadeExit: {
            opacity: 0
        },
        fadeExitActive: {
            opacity: 0
        }
    });

    return (
        <div className={css(style.product)}>
            <div className={css(style.returnList)}>
                <Link to="/">一覧に戻る</Link>
            </div>
            <Suspense fallback={
                <div className="now-fetching">
                    <p>... 情報取得中です ...</p>
                </div>
            }>
                {product == null ? null :
                    <TransitionGroup>
                        <CSSTransition
                            key={product.id}
                            in={onAnimationBegin}
                            classNames={{
                                enter: css(style.fadeEnter),
                                enterActive: css(style.fadeEnterActive),
                                enterDone: css(style.fadeEnterDone),
                                exit: css(style.fadeExit),
                                exitActive: css(style.fadeExitActive)
                            }}
                            timeout={{ enter: 500, exit: 500 }}
                        >
                            <>
                                <ProductReport product={product} prevProduct={prevProduct} nextProduct={nextProduct} />
                            </>
                        </CSSTransition>
                    </TransitionGroup>
                }
            </Suspense>
        </div>
    );
}

export default Kashi;
