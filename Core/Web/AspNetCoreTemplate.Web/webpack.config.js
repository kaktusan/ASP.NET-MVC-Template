/// <binding BeforeBuild='Run - Development' AfterBuild='Run - Development' />
var webpack = require('webpack');
var path = require('path');

var buildDir = path.resolve(__dirname, './wwwroot/scripts');
var scriptsDir = path.resolve(__dirname, './wwwroot/libs/tsxbuild');
//var scriptsDir = path.resolve(__dirname, './Scripts');

var config = {
    entry: {
        home: scriptsDir + '/folder' + '/home',
        vendor: ['react', 'react-dom']
    },
    output: {
        path: buildDir,
        filename: '[name].chunk.js'
    },
    resolve: {
        extensions: ['.js', '.jsx', '.tsx']
    },
    devtool: 'source-map',
    //module: {
    //    loaders: [
    //      {
    //          test: /\.tsx$/,
    //          loader: 'ts-loader',
    //          exclude: /(node_modules)/
    //      }
    //    ]
    //},
    plugins: [
        new webpack.optimize.CommonsChunkPlugin(({ name: 'vendor', filename: 'vendor.bundle.js' }))
    ],
    externals: {
        'Config': JSON.stringify(process.env.ENV === 'production' ?
            {
                apiUrl: "http://accountgo-dev-api.azurewebsites.net/"
            } :
            {
                apiUrl: "http://localhost:5000/"
            })
    }
};

module.exports = config;