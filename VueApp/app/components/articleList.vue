<template>
    <div id="articleList">
        <div class = "list-group">
            <div class = "list-group-item"  v-for="article in articles">
                <div class ="list-group-item-header" v-on:click="toggleDetails(article.id)">
                     <span>{{ article.title }}</span>
                     <span class="list-group-item-right">{{ article.id }}</span>
                </div>
                <articleDetails v-show="showDetails(article.id)" :article="article"></articleDetails>
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
                const article = this.articles.find(article => article.id ==id);
                return article.showDetails;
            },
            toggleDetails(id) {
                const article = this.articles.find(article => article.id == id);
                article.showDetails = !article.showDetails;
            }
        },
        components : {
            articleDetails : articleDetails
        }
    }
</script>

<style scoped> 
    .list-group-item-right {
        float: right;
    }

    .list-group-item-header {
        font-weight: bold;
    }
</style>