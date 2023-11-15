import { render, screen } from '@testing-library/react'
import { StyleSheetTestUtils } from 'aphrodite';
import React from 'react';
import { BrowserRouter } from 'react-router-dom';
import { Company } from '../../types/company';
import { Product } from '../../types/product';
import { Taste } from '../../types/taste';
import { Texture } from '../../types/texture';
import ProductReport from '../ProductReport';

const product = new Product(2, 'ポッキーチョコレート', '西洋菓子', 'チョコレート類', '準チョコレート', 108, 2, '袋（パック）',
    '軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。\r\n        ポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。',
    new Company('江崎グリコ株式会社', '555-8502', '日本', '大阪府大阪市', '西淀川区歌島四丁目6番5号', '0120-917-111'),
    [new Texture('かたい',2)],
    [new Taste('甘い', 3)]
);

const prevProduct = new Product(1, 'トッポ', '西洋菓子', 'チョコレート類', '準チョコレート', 108, 2, '袋（パック）',
    'トッポは最後までチョコたっぷり!おいしくなったトッポを、仲間との楽しい会話のお供にどうぞ。',
    new Company('森永製菓株式会社', '108-8403', '日本', '東京都港区', '芝5-33-1', '0120-560-162'),
    [new Texture('かたい', 4)],
    [new Taste('甘い', 2)]
);

const nextProduct = new Product(3, '堅あげポテト　はまぐりだし味', '西洋菓子', 'スナック類', 'ポテトチップス', 108, 63, 'g(グラム) ',
    '噛むほどうまい ! 堅い食感でじゃがいものおいしさをじっくり楽しめるポテトチップスです。\r\n        はまぐりのお吸い物のような、旨み感じる堅あげポテトです。噛むほどにじゅわっと感じる貝のおだしの味わいがくせになるおいしさです。',
    new Company('カルビー株式会社', '100-0005', '日本', '東京都千代田区', '丸の内1-8-3 丸の内トラストタワー本館22階', '0120-55-8570'),
    [new Texture('パリパリしている', 7)],
    [new Taste('しょっぱい', 3)]
);

jest.mock('react-chartjs-2', () => ({
    Bar: () => null,
}))

beforeEach(() => {
    StyleSheetTestUtils.suppressStyleInjection();
});

afterEach(() => {
    StyleSheetTestUtils.clearBufferAndResumeStyleInjection();
});

test('render ProductReport test', () => {
    render(<ProductReport product={product} prevProduct={prevProduct} nextProduct={nextProduct} />, { wrapper: BrowserRouter });

    const productName = screen.getByText('ポッキーチョコレート');

    expect(productName).not.toBeNull();

    // getByTextだと完全一致。findByTextだと、一部一致で良い。前の商品のリンクにはテキストの途中にsplanタグなど入ってしまっているため商品名で部分一致を取っている。
    const prevProductName = screen.findByText('トッポ');

    expect(prevProductName).not.toBeNull();

    const nextProductName = screen.findByText('堅あげポテト　はまぐりだし味');

    expect(nextProductName).not.toBeNull();

    const makerName = screen.getByText('江崎グリコ株式会社');

    expect(makerName).not.toBeNull();

    const textureScore = screen.getByText('かたい:2');

    expect(textureScore).not.toBeNull();

    const tasteScore = screen.getByText('甘い:3');

    expect(tasteScore).not.toBeNull();
});
