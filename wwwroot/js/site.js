if (document.querySelector('.bubble')){
    document.addEventListener("DOMContentLoaded", function () {
        const canvas = document.querySelector('.canvas');
        for (let i = 0; i < 50; i++) {
            const bubble = document.createElement('div');
            bubble.className = 'bubble';
            bubble.style.width = `${randomSize()}px`;
            bubble.style.height = bubble.style.width;
            bubble.style.left = `${randomPercent()}%`;
            bubble.style.animationDuration = `${randomDuration()}s`;

            canvas.appendChild(bubble);
        }
    });

    function randomSize() {
        return Math.floor
            (Math.random() * (100 - 5 + 1)) + 5;
    }

    function randomPercent() {
        return Math.floor(Math.random() * 100);
    }

    function randomDuration() {
        return Math.floor(Math.random() * (15 - 5 + 1)) + 5;
    }
}
