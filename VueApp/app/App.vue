<template>
  <div id="app" class="center-block">
    <articleList :articles = "articles"></articleList>
  </div>
</template>
<script>

import articleList from './components/articleList';

export default {
  name: 'app',
  data () {
    return {
      articles : [
          {id: 1, title: "article1", text: "artilce 1 text", showDetails : false},
          {id: 2, title: "article2", text: "artilce 2 text", showDetails : false},
          {id: 3, title: "article3", text: "artilce 3 text", showDetails : false},
          {id: 4, title: "article4", text: "artilce 4 text", showDetails : false}
      ]
    }
  },
  components : {
    articleList :articleList 
  }
}
</script>

<style>
  #app {
    width: 300px;
    margin-top:20px;
  }
</style>