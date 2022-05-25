<template>
    <!-- Material form login -->
                    <div class="card  text-dark bg-light mb-3 col-md-6 col-xs-12 mb-4 mt-5 pl-0 pr-0">
                        <div class="card-header">
                        <h5 class="card-title"><i aria-hidden="true"
                                   class="fas fa-street-view red-text accent-4 pr-2 fa-2x"></i>Sign in</h5>
                           
                        </div>
                        <!--Card content-->
                        <div class="card-body">
                            <!-- Form -->
                            <div class="text-left" style="color: #757575">
                                <!-- Email -->
                                <div class="md-form">
                                    <input type="text" id="txt_UserID" class="form-control" v-bind:class="{ 'is-invalid': UserName_Validate }" v-model="UserName" />
                                    <label for="txt_UserID">Username Or Email</label>
                                    <div class="invalid-feedback">*Required.</div>
                                </div>

                                <!-- Password -->
                                <div class="md-form">
                                    <input type="password" id="txt_Pass" class="form-control" v-bind:class="{ 'is-invalid': Pass_Validate }" v-model="Pass" />
                                    <label for="txt_Pass">Password</label>
                                    <div class="invalid-feedback">*Required.</div>
                                </div>

                                <div class="md-form">
                                    <input type="checkbox" class="form-check-input" id="materialLoginFormRemember" /> <label class="form-check-label" for="materialLoginFormRemember">Remember me</label>
                                </div>
                                <!-- Sign in button -->
                                <hr/>
                                <button class="w-100 btn btn-primary btn-lg" type="button" v-on:click="Execute"> Sign in </button>
                            </div>
                            <!-- Form -->
                        </div>
                    </div>
                    <!-- Material form login -->
</template>
<script>
    // import func from "vue-editor-bridge";
    export default {
        name: "UserComponent",
        props: {},
        data() {
            return {
                UserName: "",
                Pass: "",
            };
        },
        methods: {
            init: function () { },
            Execute: function () { },
            
        },
        computed: {},
        mounted() {
            this.init();
        },
    };
</script>
