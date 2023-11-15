import color from './colorScheme.css';

const cardStyle = (width: number, cardColor = color.gray, padding = '7px 14px') => {
    return {
        width: `${width}px`,
        padding: `${padding}`,
        margin: '10px',
        boxShadow: '3px 3px 3px rgba(0,0,0,0.2)',
        backgroundColor: `${cardColor}`
    };
}

export default cardStyle;
