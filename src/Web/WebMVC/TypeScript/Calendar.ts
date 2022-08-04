class Calendar {
    public async Passed(): Promise<void> {
        return new Promise<void>((resolve, reject) => {
            console.log('passei aqui');
        });
    }
    public Log(): void {

        console.log('passei aqui duas vezes');
    }
    public GetEvents(): void {
        const url = "/api/Calendar/GetEvents";
        const xhr: XMLHttpRequest = new XMLHttpRequest();
        xhr.open("Get", url, false);
        xhr.send(null);
    }
}

