var app = new Vue({
    el: "#app",
    data() {
        return {
            lista: [],
            busca: ''
        };
    },
    created() {
        this.loadDados();
    },
    methods: {
        loadDados: function () {
            var self = this;

            var xhr = new XMLHttpRequest();
            xhr.open("GET", `http://localhost:5000/Posts?buscar=${this.busca}`);
            xhr.addEventListener("load", function () {
                var resposta = xhr.responseText;
                self.lista = JSON.parse(resposta).slice(0, 10);
            });
            xhr.send();
        }
    }
});