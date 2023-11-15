import { OrderCondition, Order } from '../OrderCondition';
import { Product } from '../Product';

const firstProduct = new Product(1, 1, '1966-01-01T00:00:00', '2999-12-31T00:00:00', 'ポッキーチョコレート', '西洋菓子', 'チョコレート類', '準チョコレート', 278, 9, '袋（パック）',
    '軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。\r\nポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。', '江崎グリコ株式会社', '江崎グリコ株式会社');

const secondProduct = new Product(2, 1, '1966-01-01T00:00:00', '2999-12-31T00:00:00', 'つぶつぶポッキーチョコレートいちご', '西洋菓子', 'チョコレート類', '準チョコレート', 108, 2, '袋（パック）',
    '軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。\r\nポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。', '江崎グリコ株式会社', '江崎グリコ株式会社');

const thirdProduct = new Product(3, 1, '1966-01-01T00:00:00', '2999-12-31T00:00:00', 'アーモンドクラッシュポッキー', '西洋菓子', 'チョコレート類', '準チョコレート', 138, 2, '袋（パック）',
    'クラッシュしたアーモンドを、１本にぎっしりと散りばめました。\r\n        ミルクチョコレートと香ばしいアーモンドの旨みが織りなす絶妙なおいしさです。', '江崎グリコ株式会社', '江崎グリコ株式会社');

const products = [firstProduct, secondProduct, thirdProduct];

test('createDefault test', () => {
    const defaultOrderCondition = OrderCondition.createDefault();

    expect(defaultOrderCondition.orderKey).toBeNull();

    expect(defaultOrderCondition.order).toBeNull();
});

test('recreate by id when order is null test', () => {
    const initialOrderCondition = OrderCondition.createDefault();

    const recreatedOrderConditionById = OrderCondition.recreate(initialOrderCondition, 'id');

    expect(recreatedOrderConditionById.orderKey).toBe('id');

    expect(recreatedOrderConditionById.order).toBe(Order.Asc);
});

test('recreate by name when order is asc test', () => {
    const initialOrderCondition = new OrderCondition(null, Order.Asc);

    const recreatedOrderConditionById = OrderCondition.recreate(initialOrderCondition, 'name');

    expect(recreatedOrderConditionById.orderKey).toBe('name');

    expect(recreatedOrderConditionById.order).toBe(Order.Desc);
});

test('recreate by name when order is desc test', () => {
    const initialOrderCondition = new OrderCondition(null, Order.Desc);

    const recreatedOrderConditionById = OrderCondition.recreate(initialOrderCondition, 'name');

    expect(recreatedOrderConditionById.orderKey).toBe('name');

    expect(recreatedOrderConditionById.order).toBe(Order.Asc);
});

test('getOrderText when target is different test', () => {
    const orderCondition = new OrderCondition('id', Order.Asc);
    
    expect(orderCondition.getOrderText('name')).toBe('');
});

test('getOrderText when order is asc test', () => {
    const orderCondition = new OrderCondition('id', Order.Asc);

    expect(orderCondition.getOrderText('id')).toBe('▼');
});

test('getOrderText when order is desc test', () => {
    const orderCondition = new OrderCondition('id', Order.Desc);

    expect(orderCondition.getOrderText('id')).toBe('▲');
});

test('orderBy when order condition is empty test', () => {
    const orderedProducts = OrderCondition.orderBy(products, OrderCondition.createDefault());

    expect(orderedProducts).not.toBeNull();

    expect(orderedProducts?.length).toBe(3);

    expect(orderedProducts).toStrictEqual(products);
});

test('orderBy id asc test', () => {
    const orderCondition = new OrderCondition('id', Order.Asc);

    const orderedProducts = OrderCondition.orderBy(products, orderCondition);

    expect(orderedProducts).not.toBeNull();

    expect(orderedProducts?.length).toBe(3);

    expect(orderedProducts).toStrictEqual([firstProduct,secondProduct,thirdProduct]);
});

test('orderBy id desc test', () => {
    const orderCondition = new OrderCondition('id', Order.Desc);

    const orderedProducts = OrderCondition.orderBy(products, orderCondition);

    expect(orderedProducts).not.toBeNull();

    expect(orderedProducts?.length).toBe(3);

    expect(orderedProducts).toStrictEqual([thirdProduct, secondProduct, firstProduct]);
});

test('orderBy name asc test', () => {
    const orderCondition = new OrderCondition('name', Order.Asc);

    const orderedProducts = OrderCondition.orderBy(products, orderCondition);

    expect(orderedProducts).not.toBeNull();

    expect(orderedProducts?.length).toBe(3);

    expect(orderedProducts).toStrictEqual([secondProduct, thirdProduct , firstProduct]);
});

test('orderBy name desc test', () => {
    const orderCondition = new OrderCondition('name', Order.Desc);

    const orderedProducts = OrderCondition.orderBy(products, orderCondition);

    expect(orderedProducts).not.toBeNull();

    expect(orderedProducts?.length).toBe(3);

    expect(orderedProducts).toStrictEqual([firstProduct, thirdProduct, secondProduct]);
});

test('orderByAsc by id test', () => {
    const orderedProducts = OrderCondition.orderByAsc(products, 'id');

    expect(orderedProducts).not.toBeNull();

    expect(orderedProducts?.length).toBe(3);

    expect(orderedProducts).toStrictEqual([firstProduct, secondProduct, thirdProduct]);
});

test('orderByAsc by name test', () => {
    const orderedProducts = OrderCondition.orderByAsc(products, 'name');

    expect(orderedProducts).not.toBeNull();

    expect(orderedProducts?.length).toBe(3);

    expect(orderedProducts).toStrictEqual([secondProduct, thirdProduct, firstProduct]);
});

test('orderByDesc by id test', () => {
    const orderedProducts = OrderCondition.orderByDesc(products, 'id');

    expect(orderedProducts).not.toBeNull();

    expect(orderedProducts?.length).toBe(3);

    expect(orderedProducts).toStrictEqual([thirdProduct, secondProduct, firstProduct]);
});

test('orderByDesc by name test', () => {
    const orderedProducts = OrderCondition.orderByDesc(products, 'name');

    expect(orderedProducts).not.toBeNull();

    expect(orderedProducts?.length).toBe(3);

    expect(orderedProducts).toStrictEqual([firstProduct, thirdProduct, secondProduct]);
});
