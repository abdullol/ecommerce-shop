import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppModule } from '../app.module';
import { ShopModule } from '../shop/shop.module';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    AppModule,
    ShopModule,
  ],
})
export class SharedModule { }
