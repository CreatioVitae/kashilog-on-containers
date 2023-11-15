import React from 'react';
import { Product } from '../types/product';
import { css, StyleSheet } from 'aphrodite';
import cardStyle from '../../../../utils/styles/card.css';
import color from '../../../../utils/styles/colorScheme.css';
import { Link } from 'react-router-dom';
import contentsTitle from '../../../../utils/styles/contentsTitle.css';
import GlobalSettings from '../../../../config/GlobalSettings';
import { Bar } from 'react-chartjs-2';
import { Chart as ChartJS, CategoryScale, LinearScale, BarElement } from "chart.js";

// Memo: chart.jsでグラフ描画する際にChartJS.registerを行う必要がある
ChartJS.register(CategoryScale, LinearScale, BarElement);

const globalSettings = new GlobalSettings();

const ProductReport = (props: { product: Product, prevProduct: Product | null, nextProduct: Product | null }) => {
    let textureLabels: Array<string> = [];
    let textureData: Array<number> = [];

    props.product.textures.forEach((texture) => {
        textureLabels.push(texture.name);
        textureData.push(texture.value);
    });

    const textureBarChartData = {
        labels: textureLabels,
        datasets: [
            {
                label: '食感スコア',
                backgroundColor: 'rgba(221, 149, 54, 1.0)',
                data: textureData
            }
        ]
    };

    let tasteLabels: Array<string> = [];
    let tasteData: Array<number> = [];

    props.product.tastes.forEach((taste) => {
        tasteLabels.push(taste.name);
        tasteData.push(taste.value);
    });

    const tasteBarChartData = {
        labels: tasteLabels,
        datasets: [
            {
                label: '味スコア',
                backgroundColor: 'rgba(192, 47, 67, 1.0)',
                data: tasteData
            }
        ]
    };

    const style = StyleSheet.create({
        card: cardStyle(800, color.white, '7px 14px 7px 0'),
        overview: {
            margin: '14px 0 0 14px'
        },
        categories: {
            display: 'flex'
        },
        category: {
            padding: '8px',
            position: 'relative',
            ':after': {
                position: 'absolute',
                top: 0,
                left: '100%',
                content: '""',
                width: 0,
                height: 0,
                border: '16px solid transparent'
            }
        },
        red: {
            zIndex: 3,
            color: `${color.white}`,
            backgroundColor: `${color.red}`,
            ':after': {
                borderLeft: `10px solid ${color.red}`
            }
        },
        black: {
            zIndex: 2,
            color: `${color.white}`,
            padding: '8px 8px 8px 16px',
            backgroundColor: `${color.black}`,
            ':after': {
                borderLeft: `10px solid ${color.black}`
            }
        },
        gray: {
            zIndex: 1,
            padding: '8px 8px 8px 16px',
            backgroundColor: `${color.gray}`,
            ':after': {
                borderLeft: `10px solid ${color.gray}`
            }
        },
        title: contentsTitle(),
        subTitle: {
            display: 'inline-block',
            fontSize: '20px',
            padding: '0 0 4px 0',
            margin: '8px 0 8px 0',
            borderBottom: `1px solid ${color.gray}`,
            position: 'relative',
        },
        price__amount: {
            display: 'inline-block',
            padding: '14px',
            margin: '16px 0 8px 0',
            backgroundColor: `${color.gray}`
        },
        description: {
            margin: '8px 0'
        },
        balloon: {
            position: 'absolute',
            display: 'inline-block',
            margin: '1.5em 0',
            padding: '7px 10px',
            minWidth: '120px',
            maxWidth: '100%',
            color: '#555',
            fontSize: '16px',
            background: '#DDDDDD',
            ':before': {
                content: "",
                position: "absolute",
                top: "-30px",
                left: "50%",
                marginLeft: "-15px",
                border: "15px solid transparent",
                borderBottom: "15px solid #DDDDDD"
            },
            '*p': {
                margin: 0,
                padding: 0
            }
        },
        none: {
            display: 'none'
        },
        f10: {
            fontSize: 12
        },
        prev: {
            width: "15px",
            height: "50px",

        },
        next: {
            width: "15px",
            height: "50px",
            margin: "auto",
        },
        moveProduct: {
            position: "absolute",
            top: "40px",
            right: "15px"
        }
   });

    return (
        <>
            <div className={css(style.card)}>
                <ul className={css(style.categories)}>
                    <li className={css(style.category, style.red)}>{props.product.largeCategory}</li>
                    <li className={css(style.category, style.black)}>{props.product.middleCategory}</li>
                    <li className={css(style.category, style.gray)}>{props.product.smallCategory}</li>
                </ul>

                <div className={css(style.overview)}>
                    <div>
                        <h1 className={css(style.title)}>
                            {props.product.name}
                        </h1>
                    </div>
                    <div>
                        {globalSettings.isSmartPhone ?
                            <h2 className={css(style.subTitle)}
                                onTouchStart={() => {
                                    const companyInformation = document.getElementById("companyInformation");

                                    if (companyInformation == null) {
                                        return;
                                    }

                                    companyInformation.className = css(style.balloon);
                                }}
                                onTouchEnd={() => {
                                    setTimeout(() => {
                                        const companyInformation = document.getElementById("companyInformation");

                                        if (companyInformation == null) {
                                            return;
                                        }

                                        companyInformation.className = css(style.balloon, style.none);
                                    }, 2000);
                                }}
                            >
                                {props.product.maker.name}
                            </h2>
                            : <h2 className={css(style.subTitle)}
                                    onMouseEnter={()=>{
                                        const companyInformation = document.getElementById("companyInformation");

                                        if (companyInformation == null) {
                                            return;
                                        }

                                        companyInformation.className = css(style.balloon);
                                    }}
                                    onMouseLeave={()=>{
                                        const companyInformation = document.getElementById("companyInformation");

                                        if (companyInformation == null) {
                                            return;
                                        }

                                        companyInformation.className = css(style.balloon, style.none);
                                    }}>
                                {props.product.maker.name}
                            </h2>
                        }
                        <div id="companyInformation" className={css(style.balloon, style.none)}>
                            <p>〒{props.product.maker.zipCode}</p>
                            <p>{props.product.maker.country}</p>
                            <p>{props.product.maker.city}</p>
                            <p>{props.product.maker.address}</p>
                            <p>TEL:{props.product.maker.telephoneNumber}</p>
                        </div>
                    </div>
                    <div>
                        <p className={css(style.price__amount)}>
                            {props.product.unitPrice} <span className={css(style.f10)}>円</span> / {props.product.amount}<span className={css(style.f10)}>{props.product.amountType}</span>
                        </p>
                    </div>
                    <p className={css(style.description)}>
                        {props.product.description}
                    </p>
                </div>
            
                <div className={css(style.moveProduct)}>
                    {!(props.prevProduct === undefined || props.prevProduct === null) ?
                        <Link className={css(style.prev)} to={`/product/${props.prevProduct.id}`}>＜＜{props.prevProduct.name} {props.prevProduct.amount}<span className={css(style.f10)}>{props.prevProduct.amountType}</span></Link>
                        : null}
                    {!(props.prevProduct === undefined || props.prevProduct === null) && !(props.nextProduct === undefined || props.nextProduct === null) ? "｜" : null}
                    {!(props.nextProduct === undefined || props.nextProduct === null) ?
                        <Link className={css(style.next)} to={`/product/${props.nextProduct.id}`}>{props.nextProduct.name} {props.nextProduct.amount}<span className={css(style.f10)}>{props.nextProduct.amountType}</span>＞＞</Link>
                        : null}
                </div>         
            </div>
            <div className={css(style.card)}>
                <div>
                    <h3 className={css(style.title)}>
                        {props.product.name} 分析結果
                    </h3>
                </div>

                <div id="product-textures">
                    <h4>食感スコア</h4>
                    <ul>
                        {props.product.textures.map((texture,index) => {
                            return (
                                <li key={index}>{texture.name}:{texture.value}</li>
                            );
                        })}
                    </ul>
                    <Bar
                        data={textureBarChartData}
                        width={620}
                        options={{
                            maintainAspectRatio: false,
                            responsive: false,
                            scales: {
                                x: {
                                    beginAtZero: true,
                                    min: 0,
                                    max: 10
                                }
                            }
                        }}
                    />
                </div>
                <div id="product-tastes">
                    <h5>味スコア</h5>
                    <ul>
                        {props.product.tastes.map((taste, index) => {
                            return (
                                <li key={index}>{taste.name}:{taste.value}</li>
                            );
                        })}
                    </ul>
                    <Bar
                        data={tasteBarChartData}
                        width={620}
                        options={{
                            maintainAspectRatio: false,
                            responsive: false,
                            scales: {
                                x: {
                                    beginAtZero: true,
                                    min: 0,
                                    max: 10
                                }
                            }
                        }}
                    />
                </div>
            </div>
        </>
    );
}

export default ProductReport;
