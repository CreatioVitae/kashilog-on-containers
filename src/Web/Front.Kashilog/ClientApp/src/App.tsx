import React from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter } from 'react-router-dom';
import Root from './index';

const rootElement = document.getElementById('products');

if (rootElement != null) {
    const root = createRoot(rootElement);

    root.render(
        <React.StrictMode>
            <BrowserRouter>
                <Root />
            </BrowserRouter>
        </React.StrictMode>
    );
}
