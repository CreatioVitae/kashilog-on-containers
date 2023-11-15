import React from 'react';
import { Product } from '../types/Product';
import { css, StyleSheet } from 'aphrodite';
import cardStyle from '../../../../utils/styles/card.css';
import color from '../../../../utils/styles/colorScheme.css';
import { Link } from 'react-router-dom';

const Kashi = (props: { product: Product }) => {
    const style = StyleSheet.create({
        card: cardStyle(280),
        productName: {
            margin: '8px 14px',
            fontSize: '20px',
            textAlign: 'center',
        },
        productNameFrame: {
            paddingTop: '4px',
            margin: '0 14px',
            backgroundColor: `${color.white}`,
            position: 'relative'
        },
        description: {

        },
        moreSeeBox: {
            textAlign: 'right',
        },
        moreSeeAnchor: {
            display: 'inline-block',
            color: `${color.white}`,
            padding: '10px 15px',
            backgroundColor: `${color.black}`,
            fontSize: 17,
            transition: 'ease 0.2s',
            ':hover': {
                color: `${color.black}`,
                backgroundColor: `${color.yellow}`
            }
        },
        price__amount: {
            display: 'inline-block',
            padding: '5px',
            margin: '0',
            backgroundColor: `#DDDDDD`,
            fontSize: 12,
        },
        f8: {
            fontSize: 8,
        },
        price__amount_wrap: {
            textAlign: 'right'
        },
    });

    return (
        <div className={css(style.card)}>
            <div className={css(style.productNameFrame)}>
                <h2 className={css(style.productName)} data-testid="product-name">
                    {props.product.name}
                </h2>
                <div className={css(style.price__amount_wrap)}>
                    <p className={css(style.price__amount)}>
                        {props.product.unitPrice} <span className={css(style.f8)}>円</span> / {props.product.amount}<span className={css(style.f8)}>{props.product.amountType}</span>
                    </p>
                </div>
            </div>
            {/*<h3>{this.props.product.smallCategory}</h3>*/}
                    
            <p>
                {props.product.description}
            </p>
            <div className={css(style.moreSeeBox)}>
                <Link className={css(style.moreSeeAnchor)} to={`/product/${props.product.id}`}>もっと見る</Link>
            </div>
        </div>
    );
}

export default Kashi;
