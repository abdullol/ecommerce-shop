import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BasketService } from './basket/basket.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  title = 'ecommerceShop-client';
  constructor(private basketService: BasketService) {}
  ngOnInit(): void {
    const basketId = localStorage.getItem('basket_id');
    if (basketId) {
      this.basketService.getBasket(basketId).subscribe(
        () => {
          console.log('initialzize basket');
        },
        (error) => {
          console.log(error);
        }
      );
    }
  }
}
