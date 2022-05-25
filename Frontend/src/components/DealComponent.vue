<template>
    <div class="card text-dark bg-light mb-3">
        <div class="card-header text-start">Search prototype - Connected to BackEND ip : {{BackendURL}}</div>
        <div class="card-body">
            <div class="row">
                <div class="col-10">
                    <!-- Comment
                      <select v-model="Category_selected">
                        <option selected disabled value="0">filter by Category</option>
                        <option
                          v-for="option in Category"
                          v-bind:value="option.id"
                          v-bind:key="option.id"
                        >
                          {{ option.name }}
                        </option>
                      </select>-->
                </div>
                <div class="col-2">
                    <!-- Comment
                      <button
                        type="button"
                        class="btn btn-primary"
                        v-on:click="GetAllDeals"
                      >
                        Search
                      </button> -->
                </div>
            </div>
            <div class="row">
                <div></div>
            </div>
        </div>
    </div>

    <div>{{ msg }}</div>
    <div>
    </div>
    <!--Comment-->
    <table class="table">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Description-Short</th>
                <th scope="col">Description</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="item in Deals" :key="item.id">
                <th scope="row">{{ item.id }}</th>
                <td>{{ item.descriptionShort }}</td>
                <td>{{ item.description }}</td>
            </tr>
        </tbody>
    </table>
</template>
<script>
    // import { onMounted } from 'vue';
    import axios from "axios";

    export default {
        name: "DealComponent",
        props: {
            msg: String,
        },
        data() {
            return {
                Deals: [],
                Category: [],
                Category_selected: 0,

                BackendURL: process.env.VUE_APP_ROOT_API_D,
            };
        },
        methods: {
            init: function () {
                this.GetAllDeals();
                this.GetAllCategory();
            },
            GetAllDeals: function () {
                axios.get(this.BackendURL + "/API/deal/All").then((response) => {
                    this.Deals = response.data;
                });
            },
            GetAllCategory: function () {
                axios
                    .get(this.BackendURL + "/API/sys/category")
                    .then((response) => {
                        this.Category = response.data;
                    });
            },
        },
        computed: {},
        mounted() {
            this.init();
        },
    };
</script>
