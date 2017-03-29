var path = require('path');

function resolve (dir) {
  return path.join(__dirname, '..', dir)
}
module.exports = {
  entry: {
    app : './VueApp/app/main.js'
  },
  output: {
    filename: '[name].js',
    path: path.resolve(__dirname, 'TestApp/Scripts')
  },
  resolve: {
    extensions: ['.js', '.vue', '.json'],
    alias: {
      'vue$': 'vue/dist/vue.esm.js',
      '@': resolve('app'),
    }
  },
  module : {
    rules: [
      {
        test: /\.vue$/,
        loader: 'vue-loader'
      }
    ]
  }
};