import React from 'react';
import { render, screen } from '@testing-library/react';
import { StyleSheetTestUtils } from 'aphrodite';
import { Product } from '../../types/Product';
import Kashi from '../Kashi';
import { BrowserRouter } from 'react-router-dom';

const product = new Product(1, 1, '1966-01-01T00:00:00', '2999-12-31T00:00:00', 'ポッキーチョコレート', '西洋菓子', 'チョコレート類', '準チョコレート', 278, 9, '袋（パック）',
    '軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。\r\nポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。', '江崎グリコ株式会社', '江崎グリコ株式会社');

beforeEach(() => {
    StyleSheetTestUtils.suppressStyleInjection();
});

afterEach(() => {
    StyleSheetTestUtils.clearBufferAndResumeStyleInjection();
});

test('render productReport test', () => {
    render(<Kashi product={product} />, { wrapper: BrowserRouter });

    const productName = screen.getByText('ポッキーチョコレート');

    expect(productName).not.toBeNull();

    const unitPrice = screen.findByText('278');

    expect(unitPrice).not.toBeNull();

    const descriptionFirstLine = screen.findByText('軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。');

    expect(descriptionFirstLine).not.toBeNull();

    const descriptionSecondLine = screen.findByText('ポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。');

    expect(descriptionSecondLine).not.toBeNull();
});
