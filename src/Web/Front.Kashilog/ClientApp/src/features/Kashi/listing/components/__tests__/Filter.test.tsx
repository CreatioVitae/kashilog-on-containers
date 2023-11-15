import { render, screen, renderHook } from '@testing-library/react';
import React, { useState } from 'react';
import { OrderCondition } from '../../types/OrderCondition';
import { SearchCondition } from '../../types/SearchCondition';
import Filter from '../Filter';

test('render Filter test', () => {
    const { result } = renderHook(() => {
        const [searchCondition, setSearchCondition] = useState<SearchCondition>(SearchCondition.createDefault());
        const [orderCondition, setOrderCondition] = useState<OrderCondition>(OrderCondition.createDefault());

        return { searchCondition, setSearchCondition, orderCondition, setOrderCondition };
    });

    render(<Filter searchCondition={result.current.searchCondition} setSearchCondition={result.current.setSearchCondition} orderCondition={result.current.orderCondition} setOrderCondition={result.current.setOrderCondition} />);

    const productId = screen.getByText('ID');

    expect(productId).not.toBeNull();

    const productName = screen.getByText('商品名');

    expect(productName).not.toBeNull();
});
