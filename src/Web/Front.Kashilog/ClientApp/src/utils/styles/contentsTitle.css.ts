import color from './colorScheme.css';

const contentsTitle = (fontSize = 24) => {
    return {
        display: 'inline-block' as 'inline-block',
        fontSize: `${fontSize}px`,
        padding: '0 0 4px 0',
        margin: '8px 0 8px 0',
        borderBottom: `1px solid ${color.gray}`
    };
}

export default contentsTitle;
