import { css, StyleSheet } from 'aphrodite';
import React from 'react';
import { Route, Routes } from 'react-router-dom';
import Kashi from './features/Kashi/detail/components/Kashi';
import KashiList from './features/Kashi/listing/components/KashiList';
import color from './utils/styles/colorScheme.css';

const Root = () => {
    const style = StyleSheet.create({
        container: {
            width: '100%',
            height: '100%'
        },
        nav: {
            width: '300px',
            height: '100%',
            marginBottom: '5px',
            //position: 'fixed',
            backgroundColor: `${color.gray}`,
            boxShadow: '3px 0 3px rgba(0,0,0,0.3)'
        },
        header: {
            padding: '14px 0',
            backgroundColor: `${color.black}`,
        },
        title: {
            margin: 0,
            color: `${color.white}`,
            fontSize: '28px',
            textAlign: 'center'
        },
        main: {
            width: 'calc(100%-300px)',
            position: 'absolute',
            left: '300px'
        }
    });

    return (
        <div id="container" className={css(style.container)}>
            <nav className={css(style.nav)}>
                <header className={css(style.header)}>
                    <h1 className={css(style.title)}>菓子ログ</h1>
                </header>
            </nav>
            <Routes >
                <Route path="/" element={<KashiList />} />
                <Route path="/product/:id" element={<Kashi />} />
            </Routes>
        </div>
    );
}

export default Root;
