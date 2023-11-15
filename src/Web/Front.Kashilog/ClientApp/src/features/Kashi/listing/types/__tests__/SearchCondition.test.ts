import { Product } from '../Product';
import { SearchCondition } from '../SearchCondition';

const firstProduct = new Product(1, 1, '1966-01-01T00:00:00', '2999-12-31T00:00:00', 'ポッキーチョコレート', '西洋菓子', 'チョコレート類', '準チョコレート', 278, 9, '袋（パック）',
        '軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。\r\nポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。', '江崎グリコ株式会社', '江崎グリコ株式会社');

const secondProduct = new Product(2, 1, '1966-01-01T00:00:00', '2999-12-31T00:00:00', 'ポッキーチョコレート', '西洋菓子', 'チョコレート類', '準チョコレート', 108, 2, '袋（パック）',
    '軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。\r\nポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。', '江崎グリコ株式会社', '江崎グリコ株式会社');

const thirdProduct = new Product(3, 1, '1966-01-01T00:00:00', '2999-12-31T00:00:00', 'アーモンドクラッシュポッキー', '西洋菓子', 'チョコレート類', '準チョコレート', 138, 2, '袋（パック）',
    'クラッシュしたアーモンドを、１本にぎっしりと散りばめました。\r\n        ミルクチョコレートと香ばしいアーモンドの旨みが織りなす絶妙なおいしさです。', '江崎グリコ株式会社', '江崎グリコ株式会社');

const products = [firstProduct, secondProduct, thirdProduct];

test('createDefault test', () => {
    const defaultSearchCondition = SearchCondition.createDefault();

    expect(defaultSearchCondition.id).toBeNull();

    expect(defaultSearchCondition.productName).toBeNull();
});

test('recreate by id test', () => {
    const initialSearchCondition = new SearchCondition(1,'ポッキー');

    const recreatedSearchConditionById = SearchCondition.recreate(initialSearchCondition, '2', 'id');

    expect(recreatedSearchConditionById.id).toBe(2);

    expect(recreatedSearchConditionById.productName).toBe('ポッキー');
});

test('recreate by productName test', () => {
    const initialSearchCondition = new SearchCondition(1, 'ポッキー');

    const recreatedSearchConditionByProductName = SearchCondition.recreate(initialSearchCondition, 'アーモンド', 'productName');

    expect(recreatedSearchConditionByProductName.id).toBe(1);

    expect(recreatedSearchConditionByProductName.productName).toBe('アーモンド');
});

test('filterByFilteringCriteria when search condition is empty test', () => {
    const filteredProducts = SearchCondition.filterByFilteringCriteria(products, SearchCondition.createDefault());

    expect(filteredProducts.length).toBe(3);

    expect(SearchCondition.filterByFilteringCriteria(products, SearchCondition.createDefault())).toStrictEqual(products);
});

test('filterByFilteringCriteria when filter by id test', () => {
    const searchCondition = new SearchCondition(1, null);

    const filteredProducts = SearchCondition.filterByFilteringCriteria(products, searchCondition);

    expect(filteredProducts.length).toBe(1);

    expect(SearchCondition.filterByFilteringCriteria(products, searchCondition)).toStrictEqual([firstProduct]);
});

test('filterByFilteringCriteria when filter by productName test', () => {
    const searchCondition = new SearchCondition(null, 'ポッキーチョコレート');

    const filteredProducts = SearchCondition.filterByFilteringCriteria(products, searchCondition);

    expect(filteredProducts.length).toBe(2);

    expect(SearchCondition.filterByFilteringCriteria(products, searchCondition)).toStrictEqual([firstProduct,secondProduct]);
});

test('filterByFilteringCriteria when filter by id and productName test', () => {
    const searchCondition = new SearchCondition(2, 'ポッキーチョコレート');

    const filteredProducts = SearchCondition.filterByFilteringCriteria(products, searchCondition);

    expect(filteredProducts.length).toBe(1);

    expect(SearchCondition.filterByFilteringCriteria(products, searchCondition)).toStrictEqual([secondProduct]);
});
