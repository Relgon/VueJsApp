<template>
    <div id="articleDetails" class="list-item-details">
        <span>{{ article.text }}</span>
    </div>
</template>

<script>
    export default {
        props : ['article']
    }
</script>

<style sroped>
    .list-item-details {
        margin-top:20px;
        margin-bottom: 0xp;
    }
</style>