const path = require('path');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");

const stylesHandler = MiniCssExtractPlugin.loader;

const isProduction = process.env.NODE_ENV == "production";

const config = {
    output: {
        filename:'[name]/App.js',
        path: path.resolve(__dirname, '../wwwroot/js'),
    },
    entry: {
        products: "./src/App.tsx",
    },
    resolve: {
        extensions: [".ts", ".tsx", ".js", ".jsx", ".json", "css"],
        modules: [path.resolve(__dirname, 'src'), 'node_modules']
    },
    plugins: [
        new MiniCssExtractPlugin(),

    ],

    module: {
        rules: [{
            test: /\.(ts|tsx)$/,
            use: [{
                loader: "ts-loader"
            }]
        },
        {
            test: /\.css$/i,
            use: [stylesHandler, "css-loader"],
        }]
    },
    externals: {
        "react": "React",
        "react-dom": "ReactDOM"
    }
};

module.exports = () => {
    if (isProduction) {
        config.mode = "production";
    } else {
        config.mode = "development";
    }
    return config;
};
