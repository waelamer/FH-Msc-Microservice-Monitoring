<template>
    <div>
        <h1>{{ msg }}</h1>
        <div class="card text-dark bg-light mb-3">
            <div class="card-header text-start">
                Provider Prototype GUI - Connected to BackEND ip : {{BackendURL}}
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-10">

                    </div>
                    <div class="col-2">
                        <!-- Comment
                          <button
                            type="button"
                            class="btn btn-primary"
                            v-on:click="GetAllProviders"
                          >
                            Search
                          </button>-->
                    </div>
                </div>
                <div class="row">
                    <div></div>
                </div>
            </div>
        </div>

        <div>{{ msg }}</div>
        <div></div>
        <!--Comment-->
        <div class="row" v-for="item in Providers" :key="item.id">
            <div class="card  text-start">
                <div class="card-body">
                    <h5 class="card-title">{{ item.companyName }}</h5>
                    <img v-bind:src="'imgs/' + item.companyLogo" />
                    <strong>{{ item.occupation }}</strong>
                    <p class="card-text">
                        {{ item.companyDescription }}
                    </p>
                    <a href="#" class="btn btn-primary">show Deals</a>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
    import axios from "axios";

    export default {
        name: "ProviderComponent",
        props: {
            msg: String,
        },
        data() {
            return {
                Providers: [],
                Category: [],
                imgsurl: '',
                BackendURL: process.env.VUE_APP_ROOT_API_P
            };
        },
        methods: {
            init: function () {
                // get All Provider
                this.GetAllProviders();
            },
            Execute: function () { },
            GetAllProviders: function () {
                axios
                    .get(this.BackendURL + "/api/Provider/all")
                    .then((response) => {
                        this.Providers = response.data;
                    });
            },
        },
        computed: {},
        mounted() {
            this.init();
        },
    };
</script>