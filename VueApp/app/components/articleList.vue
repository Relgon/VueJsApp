<template>
    <div id="articleList">
        <div class = "list-group" v-for="article in articles">
            <div class = "list-group-item" v-on:click="toggleDetails(article.id)">
                <articleDetails v-show="showDetails(article.id)" :article="article"></articleDetails>
                <span>{{ article.title }}</span>
                <span class="right-item">{{ article.id }}</span>
                
            </div>
        </div>
    </div>
</template>

<script>
    import articleDetails from './articleDetails.vue';

    export default {
        props : ['articles'],
        methods : {
            showDetails(id) {
                const article = this.articles.filter(article => {
                    return article.Id == id;
                });
                return article.showDetails;
            },
            toggleDetails(id) {
                const article = this.articles.filter(article =>{
                    return article.id == id;
                });
                article.id = !article.id;
                console.log(article);
            }
        },
        components : {
            articleDetails : articleDetails
        }
    }
</script>

<style scoped> 
    .right-item {
        float: right;
    }
</style>