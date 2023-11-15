import { render, screen, waitFor } from '@testing-library/react'
import { StyleSheetTestUtils } from 'aphrodite';
import React from 'react';
import { MemoryRouter, Routes, Route } from 'react-router-dom';
import { server } from '../../../../../utils/mocks/server';
import Kashi from '../Kashi';

jest.mock('react-chartjs-2', () => ({
    Bar: () => null,
}))

beforeAll(() => {
    // インターセプトスタート
    server.listen()
});

afterAll(() => {
    // インターセプトストップ
    server.close()
});

beforeEach(() => {
    StyleSheetTestUtils.suppressStyleInjection();
});

afterEach(() => {
    StyleSheetTestUtils.clearBufferAndResumeStyleInjection();
    server.resetHandlers()
});

test('render ProductReport test', async () => {
    render(<input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />);

    await waitFor(() => document.getElementById(`api-url`));

    render(
        <>
            <input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />
            <MemoryRouter initialEntries={[`/product/2`]}>
                <Routes>
                    <Route path="/product/:id" element={<Kashi />} />
                </Routes>
            </MemoryRouter>
        </>
    );

    await waitFor(() => screen.getByText('ポッキーチョコレート'));

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
