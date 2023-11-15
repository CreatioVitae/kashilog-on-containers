import { rest } from 'msw'
import Products from './responses/Products.json';
import PrevProduct from './responses/PrevProduct.json';
import CurrentProduct from './responses/CurrentProduct.json';
import NextProduct from './responses/NextProduct.json';

export const handlers = [
    rest.get('http://api.mock.server/Product', (_, res, ctx) => {
        return res(ctx.status(200), ctx.set('Content-Type', 'application/json') , ctx.json(Products));
    }),

    rest.get(`http://api.mock.server/Product/1`, (_, res, ctx) => {
        return res(ctx.status(200), ctx.set('Content-Type', 'application/json'), ctx.json(PrevProduct));
    }),

    rest.get(`http://api.mock.server/Product/2`, (_, res, ctx) => {
        return res(ctx.status(200), ctx.set('Content-Type', 'application/json'), ctx.json(CurrentProduct));
    }),

    rest.get(`http://api.mock.server/Product/3`, (_, res, ctx) => {
        return res(ctx.status(200), ctx.set('Content-Type', 'application/json'), ctx.json(NextProduct));
    }),
]
