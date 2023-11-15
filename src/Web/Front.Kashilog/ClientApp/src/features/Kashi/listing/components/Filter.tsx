import React from 'react';
import { Order, OrderCondition } from '../types/OrderCondition';
import { SearchCondition } from '../types/SearchCondition';

const Filter = (props: { searchCondition: SearchCondition, setSearchCondition: React.Dispatch<React.SetStateAction<SearchCondition>>, orderCondition: OrderCondition, setOrderCondition: React.Dispatch<React.SetStateAction<OrderCondition>>}) => {
    return (
        <form>
            <div className="input-group mb-3">
                <span className="input-group-text" id="filter-id" onClick={() => props.setOrderCondition(OrderCondition.recreate(props.orderCondition, 'id'))}>ID{props.orderCondition.getOrderText('id')}</span>
                <input type="text" className="form-control" placeholder="Id" aria-label="Id" aria-describedby="filter-id" onBlur={(e) => props.setSearchCondition(SearchCondition.recreate(props.searchCondition, e.target.value, 'id'))} />
            </div>
            <div className="input-group mb-3">
                <span className="input-group-text" id="filter-productname" onClick={() => props.setOrderCondition(OrderCondition.recreate(props.orderCondition, 'name'))}>商品名{props.orderCondition.getOrderText('name')}</span>
                <input type="text" className="form-control" placeholder="商品名" aria-label="ProductName" aria-describedby="filter-productname1" onBlur={(e) => props.setSearchCondition(SearchCondition.recreate(props.searchCondition, e.target.value, 'productName'))} />
            </div>
        </form>
    );
}

export default Filter;
