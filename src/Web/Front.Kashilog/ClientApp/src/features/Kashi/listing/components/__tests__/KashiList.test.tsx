import React from 'react';
import { fireEvent, getByPlaceholderText, render, screen, waitFor, waitForElementToBeRemoved } from '@testing-library/react';
import { StyleSheetTestUtils } from 'aphrodite';
import { BrowserRouter } from 'react-router-dom';
import KashiList from '../KashiList';
import { server }  from '../../../../../utils/mocks/server';

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

test('render KashiList test', async () => {
    render(<input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />);

    await waitFor(() => document.getElementById(`api-url`));

    render(
        <>
            <input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />
            <KashiList />
        </>,
        { wrapper: BrowserRouter }
    );

    await waitFor(() => screen.getAllByText('ポッキーチョコレート'));

    const productNames = screen.getAllByText('ポッキーチョコレート');

    expect(productNames.length).toBe(3);

    const allProductNames = await screen.findAllByText(/^(?=.*ポッキー).*$/);

    expect(allProductNames.length).toBe(7);

    const firstProductUnitPrice = screen.findByText('278');

    expect(firstProductUnitPrice).not.toBeNull();

    const secondProductUnitPrice = screen.findByText('108');

    expect(secondProductUnitPrice).not.toBeNull();

    const thirdProductUnitPrice = screen.findByText('138');

    expect(thirdProductUnitPrice).not.toBeNull();

    const descriptionFirstLine = screen.findByText('軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。');

    expect(descriptionFirstLine).not.toBeNull();

    const descriptionSecondLine = screen.findByText('ポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。');

    expect(descriptionSecondLine).not.toBeNull();
});

test('render KashiList test filter by productName', async () => {
    render(<input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />);

    await waitFor(() => document.getElementById(`api-url`));

    render(
        <>
            <input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />
            <KashiList />
        </>,
        { wrapper: BrowserRouter }
    );

    await waitFor(() => screen.getAllByText('ポッキーチョコレート'));

    const productNameFilterInput = screen.getByPlaceholderText('商品名') as HTMLInputElement;
    productNameFilterInput.focus();

    productNameFilterInput.value = 'チョコレート';

    // Memo: onBlurイベントで検索条件のstateの更新が入る
    fireEvent.blur(productNameFilterInput);

    await waitForElementToBeRemoved(() => screen.getAllByText('アーモンドクラッシュポッキー'));

    const filteredProductNames = await screen.findAllByText(/^(?=.*ポッキー).*$/);

    expect(filteredProductNames.length).toBe(6);
});

test('render KashiList test filter by productId', async () => {
    render(<input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />);

    await waitFor(() => document.getElementById(`api-url`));

    render(
        <>
            <input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />
            <KashiList />
        </>,
        { wrapper: BrowserRouter }
    );

    await waitFor(() => screen.getAllByText('ポッキーチョコレート'));

    const productIdFilterInput = screen.getByPlaceholderText('Id') as HTMLInputElement;

    productIdFilterInput.focus();

    productIdFilterInput.value = '4';

    fireEvent.blur(productIdFilterInput);

    await waitForElementToBeRemoved(() => screen.getAllByText('ポッキーチョコレート'));

    const filterByIdProductName = screen.getAllByText('アーモンドクラッシュポッキー');

    expect(filterByIdProductName).not.toBeNull();
});

test('render KashiList test order by id asc', async () => {
    render(<input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />);

    await waitFor(() => document.getElementById(`api-url`));

    render(
        <>
            <input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />
            <KashiList />
        </>,
        { wrapper: BrowserRouter }
    );

    await waitFor(() => screen.getAllByText('ポッキーチョコレート'));

    const idLabel = document.getElementById('filter-id') as HTMLElement;

    fireEvent.click(idLabel);

    await waitFor(() => screen.findByText(/^(?=.*▼).*$/));

    const productNames = screen.getAllByTestId('product-name');

    expect(productNames.length).toBe(4);

    expect(productNames[0].innerHTML).toBe('ポッキーチョコレート');

    expect(productNames[3].innerHTML).toBe('アーモンドクラッシュポッキー');
});

test('render KashiList test order by id desc', async () => {
    render(<input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />);

    await waitFor(() => document.getElementById(`api-url`));

    render(
        <>
            <input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />
            <KashiList />
        </>,
        { wrapper: BrowserRouter }
    );

    await waitFor(() => screen.getAllByText('ポッキーチョコレート'));

    const idLabel = document.getElementById('filter-id') as HTMLElement;

    fireEvent.click(idLabel);

    await waitFor(() => screen.findByText(/^(?=.*▼).*$/));

    fireEvent.click(idLabel);

    await waitFor(() => screen.findByText(/^(?=.*▲).*$/));

    const productNames = screen.getAllByTestId('product-name');

    expect(productNames.length).toBe(4);

    expect(productNames[0].innerHTML).toBe('アーモンドクラッシュポッキー');

    expect(productNames[3].innerHTML).toBe('ポッキーチョコレート');
});

test('render KashiList test order by productName asc', async () => {
    render(<input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />);

    await waitFor(() => document.getElementById(`api-url`));

    render(
        <>
            <input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />
            <KashiList />
        </>,
        { wrapper: BrowserRouter }
    );

    await waitFor(() => screen.getAllByText('ポッキーチョコレート'));

    const idLabel = document.getElementById('filter-productname') as HTMLElement;

    fireEvent.click(idLabel);

    await waitFor(() => screen.findByText(/^(?=.*▼).*$/));

    const productNames = screen.getAllByTestId('product-name');

    expect(productNames.length).toBe(4);

    expect(productNames[0].innerHTML).toBe('アーモンドクラッシュポッキー');

    expect(productNames[3].innerHTML).toBe('ポッキーチョコレート');
});

test('render KashiList test order by productName desc', async () => {
    render(<input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />);

    await waitFor(() => document.getElementById(`api-url`));

    render(
        <>
            <input id="api-url" type="hidden" data-api-url="http://api.mock.server/" />
            <KashiList />
        </>,
        { wrapper: BrowserRouter }
    );

    await waitFor(() => screen.getAllByText('ポッキーチョコレート'));

    const idLabel = document.getElementById('filter-productname') as HTMLElement;

    fireEvent.click(idLabel);

    await waitFor(() => screen.findByText(/^(?=.*▼).*$/));

    fireEvent.click(idLabel);

    await waitFor(() => screen.findByText(/^(?=.*▲).*$/));

    const productNames = screen.getAllByTestId('product-name');

    expect(productNames.length).toBe(4);

    expect(productNames[0].innerHTML).toBe('ポッキーチョコレート');

    expect(productNames[3].innerHTML).toBe('アーモンドクラッシュポッキー');
});
